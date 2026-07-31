using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace GDExtensionAPIGenerator;

public partial class WrapperGeneratorMain
{
    private const string PrintIndent = "    ";
    
    public record FileConstruction(string FileName, string SourceCode);

    private class GenerationLogger(GodotClassType type)
    {
        private record struct Message(string Content,  (string Scope, string Name)[] StackTrace);
        private readonly List<Message> _messages = [];

        private readonly Stack<(string Scope, string Name)> _stack = [];
        
        public void Add(string message) => _messages.Add(new(message, _stack.ToArray()));
        
        public Scope BeginScope(string name = "", [CallerMemberName] string scopeName = "")
        {
            _stack.Push((scopeName, name));
            return new(scopeName, this);
        }

        public readonly struct Scope(string scopeName, GenerationLogger logger) : IDisposable
        {
            public void Dispose()
            {
                if (!ReferenceEquals(logger._stack.Peek().Scope, scopeName))
                    throw new UnreachableException();
                logger._stack.Pop();
            }
        }

        public bool TryGetMessages(out string message)
        {
            if (_messages.Count == 0)
            {
                message = "";
                return false;
            }
            
            var sb = new StringBuilder();
            sb.AppendLine($"[{type.GodotTypeName}]");
            foreach (var messageItem in _messages)
            {
                sb.AppendLine($"{PrintIndent}{messageItem.Content}");
                foreach (var stack in messageItem.StackTrace)
                {
                    if(string.IsNullOrEmpty(stack.Name)) sb.AppendLine($"{PrintIndent + PrintIndent}in {stack.Scope}");
                    else sb.AppendLine($"{PrintIndent + PrintIndent}in {stack.Scope}: {stack.Name}");
                }
            }
            message = sb.ToString();
            return true;
        }
    }
    
    private static class TypeWriter
    {
        public static void WriteType(
            GodotClassType type,
            string nameSpace, 
            string indent,
            ConcurrentBag<FileConstruction> files, 
            ConcurrentBag<string> warnings)
        {
            var fileBuilder = new StringBuilder();

            var logger = new GenerationLogger(type);
            type.RenderClass(fileBuilder, nameSpace, indent, logger);

            var code = fileBuilder.ToString();
            files.Add(new($"{type.CSharpTypeName}.cs", code));

            if (!logger.TryGetMessages(out var message)) return;
            
            warnings.Add(message);
        }
    }
}