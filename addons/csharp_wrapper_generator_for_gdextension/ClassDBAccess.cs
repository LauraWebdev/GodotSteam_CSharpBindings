using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Godot;
using Godot.Collections;

namespace GDExtensionAPIGenerator;

public partial class WrapperGeneratorMain
{
    private readonly record struct GodotName(string String)
    {
        public override string ToString() => String;
        public string ToPascalCase() => String.ToPascalCase();
        public string ToSnakeCase() => String.ToSnakeCase();
        public bool IsInternal() => String.StartsWith('_');
        public static GodotName Empty { get; } = new GodotName(string.Empty);
    }

    private readonly struct CSharpName(string str) : IEquatable<CSharpName>
    {
        public string String { get; } = str;
        public string EscapedString { get; } = EscapeCSharpKeyWords(str);
        public override string ToString() => String;

        public bool Equals(CSharpName other)
        {
            return String.Equals(other.String, StringComparison.Ordinal);
        }

        public override bool Equals(object obj) => obj is CSharpName other && Equals(other);

        public override int GetHashCode() => (String != null ? String.GetHashCode() : 0);
        
        public static bool operator == (CSharpName a, CSharpName b) => a.Equals(b);
        public static bool operator != (CSharpName a, CSharpName b) => !a.Equals(b);
    }
    
    private static class ClassDBAccess
    {
        public static IEnumerable<GodotName> GetClassList() => ClassDB.GetClassList().Select(x => new GodotName(x));

        public static ClassDB.ApiType ClassGetApiType(GodotName godotTypeName) => ClassDB.ClassGetApiType(godotTypeName.String);

        public static GodotName GetParentClass(GodotName godotTypeName) => new GodotName(ClassDB.GetParentClass(godotTypeName.String));

        public static bool CanInstantiate(GodotName godotTypeName) => ClassDB.CanInstantiate(godotTypeName.String);

        public static IEnumerable<GodotName> ClassGetEnumList(GodotName godotTypeName, bool noInheritance) => ClassDB.ClassGetEnumList(godotTypeName.String, noInheritance).Select(x => new GodotName(x));

        public static IEnumerable<GodotName> ClassGetEnumConstants(GodotName godotTypeName, GodotName enumName, bool noInheritance) => ClassDB.ClassGetEnumConstants(godotTypeName.String, enumName.String, noInheritance).Select(x => new GodotName(x));
        
        public static long ClassGetIntegerConstant(GodotName godotTypeName, GodotName enumConstant) => ClassDB.ClassGetIntegerConstant(godotTypeName.String, enumConstant.String);
        
        public static bool IsClassEnumBitfield(GodotName godotTypeName, GodotName enumName, bool noInheritance) => ClassDB.IsClassEnumBitfield(godotTypeName.String, enumName.String, noInheritance);

        public static IEnumerable<Dictionary> ClassGetMethodList(GodotName godotTypeName, bool noInheritance) => ClassDB.ClassGetMethodList(godotTypeName.String, noInheritance);
        
        public static IEnumerable<Dictionary> ClassGetPropertyList(GodotName s, bool noInheritance) => ClassDB.ClassGetPropertyList(s.String, noInheritance);

        public static GodotName ClassGetPropertyGetter(GodotName godotTypeName, GodotName propertyName) =>
            new GodotName(ClassDB.ClassGetPropertyGetter(godotTypeName.String, propertyName.String));

        public static GodotName ClassGetPropertySetter(GodotName godotTypeName, GodotName propertyName) =>
            new GodotName(ClassDB.ClassGetPropertySetter(godotTypeName.String, propertyName.String));

        public static IEnumerable<Dictionary> ClassGetSignalList(GodotName godotTypeName, bool noInheritance) => ClassDB.ClassGetSignalList(godotTypeName.String, noInheritance);
        
    }
}