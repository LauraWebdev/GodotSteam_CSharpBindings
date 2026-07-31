#if TOOLS
// ReSharper disable InvertIf
// ReSharper disable ConvertIfStatementToSwitchStatement
// ReSharper disable TypeWithSuspiciousEqualityIsUsedInRecord.Local

// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable SuggestVarOrType_Elsewhere

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Godot;
using GodotDictionary = Godot.Collections.Dictionary;

namespace GDExtensionAPIGenerator;

public partial class WrapperGeneratorMain
{
    private readonly record struct NormalizedEnumConstantsString(string String)
    {
        public override string ToString() => String;
        public static implicit operator string(NormalizedEnumConstantsString normalizedEnumConstantsString) => normalizedEnumConstantsString.String;
        public static implicit operator NormalizedEnumConstantsString(string normalizedEnumConstantsString) => new(normalizedEnumConstantsString);
    }

    private readonly record struct EnumName(string String)
    {
        public override string ToString() => String;
        public static implicit operator string(EnumName enumName) => enumName.String;
        public static implicit operator EnumName(string enumName) => new(enumName);
    }

    private static partial class TypeCollector
    {
        public static void CreateClassDiagram(bool exposeInternalMembers, out GodotClassType[] gdExtensionTypes, ConcurrentBag<string> warnings)
        {
            var constructedTypes = new GodotTypeMap();

            PopulateGodotVariantTypes(constructedTypes);
            PopulateGodotClassTypes(constructedTypes);

            PopulateGlobalScopeEnumTypes(constructedTypes);
            PopulateGodotClassMembers(constructedTypes, exposeInternalMembers, warnings);

            gdExtensionTypes = constructedTypes.Types.Values
                .OfType<GodotClassType>()
                .Where(x => x.ApiType is ClassDB.ApiType.Extension)
                .ToArray();
        }

        private static void PopulateGodotClassTypes(GodotTypeMap godotTypeMap)
        {
            Dictionary<GodotName, CSharpName> godotTypeNameToCSharpTypeNameMap = typeof(GodotObject).Assembly
                .GetTypes()
                .Select(x => (Attribute: x.GetCustomAttributesData().FirstOrDefault(y => y.AttributeType == typeof(GodotClassNameAttribute)), Type: x))
                .Where(x => x.Attribute != null)
                .Select(x => (GodotTypeName: new GodotName(x.Attribute.ConstructorArguments[0].Value!.ToString()), CSharpTypeName: new CSharpName(x.Type.Name)))
                .GroupBy(x => x.GodotTypeName)
                .ToDictionary(
                    x => x.Key,
                    x =>
                        x.Count() > 1
                            ? x.First(y => !y.CSharpTypeName.String.Contains("Instance")).CSharpTypeName
                            : x.First().CSharpTypeName
                );


            foreach (var godotClassName in ClassDBAccess.GetClassList())
            {
                var csharpTypeName = godotTypeNameToCSharpTypeNameMap.GetValueOrDefault(godotClassName, new(godotClassName.String));

                var apiType = ClassDBAccess.ClassGetApiType(godotClassName);
                if (apiType == ClassDB.ApiType.Extension) continue;
                if (godotClassName.String == "Object") continue;
                godotTypeMap.Types.Add(
                    godotClassName,
                    new GodotClassType(
                        godotClassName,
                        csharpTypeName,
                        csharpTypeName,
                        apiType,
                        ClassDBAccess.CanInstantiate(godotClassName)
                    )
                );
            }

            foreach (var godotClassName in ClassDBAccess.GetClassList())
            {
                var csharpTypeName = godotTypeNameToCSharpTypeNameMap.GetValueOrDefault(godotClassName, new(godotClassName.String));

                var apiType = ClassDBAccess.ClassGetApiType(godotClassName);
                if (apiType != ClassDB.ApiType.Extension) continue;

                var className = godotClassName;
                var parentApiType = apiType;
                while (parentApiType == ClassDB.ApiType.Extension)
                {
                    className = ClassDBAccess.GetParentClass(className);
                    parentApiType = ClassDBAccess.ClassGetApiType(className);
                }

                var marshalClassName = godotTypeMap.Types[className].CSharpTypeName;

                godotTypeMap.Types.Add(
                    godotClassName,
                    new GodotClassType(
                        godotClassName,
                        csharpTypeName,
                        marshalClassName,
                        apiType,
                        ClassDBAccess.CanInstantiate(godotClassName)
                    )
                );
            }

            foreach (var godotType in godotTypeMap.Types.Values.OfType<GodotClassType>())
            {
                var parentClass = ClassDBAccess.GetParentClass(godotType.GodotTypeName);
                godotType.ParentType = godotTypeMap.Types[parentClass];
            }
        }

        private static void PopulateGodotVariantTypes(GodotTypeMap godotTypeMap)
        {
            AddType("Nil", Variant.Type.Nil, "void");
            AddType("Bool", Variant.Type.Bool, "bool");
            AddType("Int", Variant.Type.Int, "long");
            AddType("Float", Variant.Type.Float, "double");
            AddType("String", Variant.Type.String, "string");
            AddType("Vector2", Variant.Type.Vector2, nameof(Vector2));
            AddType("Vector2i", Variant.Type.Vector2I, nameof(Vector2I));
            AddType("Rect2", Variant.Type.Rect2, nameof(Rect2));
            AddType("Rect2i", Variant.Type.Rect2I, nameof(Rect2I));
            AddType("Vector3", Variant.Type.Vector3, nameof(Vector3));
            AddType("Vector3i", Variant.Type.Vector3I, nameof(Vector3I));
            AddType("Transform2D", Variant.Type.Transform2D, nameof(Transform2D));
            AddType("Vector4", Variant.Type.Vector4, nameof(Vector4));
            AddType("Vector4i", Variant.Type.Vector4I, nameof(Vector4I));
            AddType("Plane", Variant.Type.Plane, nameof(Plane));
            AddType("Quaternion", Variant.Type.Quaternion, nameof(Quaternion));
            AddType("AABB", Variant.Type.Aabb, nameof(Aabb));
            AddType("Basis", Variant.Type.Basis, nameof(Basis));
            AddType("Transform3D", Variant.Type.Transform3D, nameof(Transform3D));
            AddType("Projection", Variant.Type.Projection, nameof(Projection));
            AddType("Color", Variant.Type.Color, nameof(Color));
            AddType("StringName", Variant.Type.StringName, nameof(StringName));
            AddType("NodePath", Variant.Type.NodePath, nameof(NodePath));
            AddType("Rid", Variant.Type.Rid, nameof(Rid));
            AddType("Callable", Variant.Type.Callable, nameof(Callable));
            AddType("Signal", Variant.Type.Signal, nameof(Signal));
            AddType("Dictionary", Variant.Type.Dictionary, "Godot.Collections.Dictionary");
            AddType("Array", Variant.Type.Array, "Godot.Collections.Array");
            AddType("PackedByteArray", Variant.Type.PackedByteArray, "byte[]");
            AddType("PackedInt32Array", Variant.Type.PackedInt32Array, "int[]");
            AddType("PackedInt64Array", Variant.Type.PackedInt64Array, "long[]");
            AddType("PackedFloat32Array", Variant.Type.PackedFloat32Array, "float[]");
            AddType("PackedFloat64Array", Variant.Type.PackedFloat64Array, "double[]");
            AddType("PackedStringArray", Variant.Type.PackedStringArray, "string[]");
            AddType("PackedVector2Array", Variant.Type.PackedVector2Array, "Vector2[]");
            AddType("PackedVector3Array", Variant.Type.PackedVector3Array, "Vector3[]");
            AddType("PackedColorArray", Variant.Type.PackedColorArray, "Color[]");
            AddType("PackedVector4Array", Variant.Type.PackedVector4Array, "Vector4[]");
            AddType("Object", Variant.Type.Object, nameof(GodotObject));
            return;

            void AddType(string godotName, Variant.Type variantType, string csharpName)
            {
                var godotTypeName = new GodotName(godotName);
                var csharpTypeName = new CSharpName(csharpName);
                godotTypeMap.VariantTypeToGodotName.Add(variantType, godotTypeName);
                godotTypeMap.Types.Add(godotTypeName, new GodotAnnotatedVariantType(godotTypeName, csharpTypeName, variantType));
            }
        }

        private static void PopulateGlobalScopeEnumTypes(GodotTypeMap godotTypeMap)
        {
            AddBuiltinEnum<Variant.Type>("Variant.Type", "Type", false, godotTypeMap.Variant);
            AddBuiltinEnum<Error>("Error", "Error", false, null);
            AddBuiltinEnum<Projection.Planes>("Planes", "Planes", false, null);

            return;

            void AddBuiltinEnum<TEnum>(string key, string type, bool isBitField, GodotType ownerType) where TEnum : struct, Enum
            {
                var godotEnumType = new GodotEnumType(new(type), new(type), ownerType, isBitField);
                godotTypeMap.GlobalScopeEnumTypes.Add(new(key), godotEnumType);
                var enumNames = Enum.GetNames<TEnum>();
                var enumValues = Enum.GetValues<TEnum>();
                for (int i = 0; i < enumNames.Length; i++)
                {
                    var enumName = enumNames[i];
                    var enumValue = (long)Convert.ChangeType(enumValues.GetValue(i), typeof(long))!;
                    if (i == 0)
                    {
                        godotEnumType.DefaultEnumValue = enumName;
                    }
                    godotEnumType.EnumConstants.Add((enumName, enumValue));
                }
            }
        }

        private static void PopulateGodotClassMembers(GodotTypeMap godotTypeMap, bool exposeInternalMembers, ConcurrentBag<string> warnings)
        {
            foreach (var godotClassType in godotTypeMap.SelectTypes(ClassDB.ApiType.Core, ClassDB.ApiType.Editor, ClassDB.ApiType.Extension, ClassDB.ApiType.EditorExtension))
            {
                var logger = new GenerationLogger(godotClassType);
                var enumNames = ClassDBAccess.ClassGetEnumList(godotClassType.GodotTypeName, true);
                foreach (var enumName in enumNames)
                {
                    var enumType = new GodotEnumType(enumName, new(enumName.ToPascalCase()), godotClassType, ClassDBAccess.IsClassEnumBitfield(godotClassType.GodotTypeName, enumName, true));
                    var isFirst = true;
                    foreach (var enumConstant in ClassDBAccess.ClassGetEnumConstants(godotClassType.GodotTypeName, enumName, true))
                    {
                        var enumValue = ClassDBAccess.ClassGetIntegerConstant(godotClassType.GodotTypeName, enumConstant);
                        var enumConstantName = GodotEnumType.FormatEnumName(enumName, enumConstant);
                        enumType.EnumConstants.Add((enumConstantName, enumValue));

                        if (isFirst)
                        {
                            isFirst = false;
                            enumType.DefaultEnumValue = enumConstantName;
                        }
                    }

                    godotClassType.Enums.Add(enumType);
                    if (!godotTypeMap.PreregisteredEnumTypes.TryGetValue(godotClassType, out var preregisteredEnums))
                    {
                        preregisteredEnums = [];
                        godotTypeMap.PreregisteredEnumTypes.Add(godotClassType, preregisteredEnums);
                    }

                    preregisteredEnums.Add(enumName, enumType);

                    var normalizedString = NormalizeString(enumType.EnumConstants.Select(x => x.EnumName));

                    if (!godotTypeMap.PreregisteredEnumTypesByName.TryGetValue(normalizedString, out var selections))
                    {
                        selections = [];
                        godotTypeMap.PreregisteredEnumTypesByName.Add(normalizedString, selections);
                    }

                    if (!selections.TryGetValue(godotClassType, out var enumTypes))
                    {
                        enumTypes = [];
                        selections.Add(godotClassType, enumTypes);
                    }

                    enumTypes.Add(enumName, enumType);
                }
                if (logger.TryGetMessages(out var message)) warnings.Add(message);
            }

            foreach (var godotClassType in godotTypeMap.SelectTypes(ClassDB.ApiType.Extension))
            {
                var logger = new GenerationLogger(godotClassType);
                var methodDefinitions = ClassDBAccess.ClassGetMethodList(godotClassType.GodotTypeName, true);
                foreach (var methodDefinition in methodDefinitions)
                {
                    var methodInfo = CreateFunctionInfo(godotTypeMap, methodDefinition, logger);
                    godotClassType.Methods.Add(methodInfo);
                }
                if (logger.TryGetMessages(out var message)) warnings.Add(message);
            }

            foreach (var godotClassType in godotTypeMap.SelectTypes(ClassDB.ApiType.Extension))
            {
                var logger = new GenerationLogger(godotClassType);
                var propertyDefinitions = ClassDBAccess.ClassGetPropertyList(godotClassType.GodotTypeName, true);
                foreach (var propertyDefinition in propertyDefinitions)
                {
                    var propertyInfo = CreatePropertyInfo(propertyDefinition, godotTypeMap, logger);
                    if (!exposeInternalMembers && propertyInfo.GodotName.IsInternal()) continue;
                    var csharpPropertyName = new CSharpName(propertyInfo.GodotName.String.ToPascalCase());
                    if (propertyInfo.Usage.HasFlag(PropertyUsageFlags.Group) 
                        || propertyInfo.Usage.HasFlag(PropertyUsageFlags.Category)
                        || propertyInfo.Usage.HasFlag(PropertyUsageFlags.Subgroup)) continue;
                    var getter = ClassDBAccess.ClassGetPropertyGetter(godotClassType.GodotTypeName, propertyInfo.GodotName);
                    var setter = ClassDBAccess.ClassGetPropertySetter(godotClassType.GodotTypeName, propertyInfo.GodotName);
                    var getterMethod = godotClassType.Methods.FirstOrDefault(x => x.GodotFunctionName == getter);
                    var setterMethod = godotClassType.Methods.FirstOrDefault(x => x.GodotFunctionName == setter);
                    godotClassType.Properties.Add(
                        new(
                            propertyInfo.GodotName,
                            csharpPropertyName,
                            propertyInfo.Type,
                            setterMethod,
                            getterMethod
                        )
                    );
                }

                foreach (var propertyInfo in godotClassType.Properties)
                {
                    if (propertyInfo.Getter is not null) godotClassType.Methods.Remove(propertyInfo.Getter);
                    if (propertyInfo.Setter is not null) godotClassType.Methods.Remove(propertyInfo.Setter);
                }
                if (logger.TryGetMessages(out var message)) warnings.Add(message);

                if (!exposeInternalMembers)
                {
                    for (int i = godotClassType.Methods.Count - 1; i >= 0; i--)
                    {
                        var method = godotClassType.Methods[i];
                        if (!method.GodotFunctionName.IsInternal()
                            || method.Flags.HasFlag(MethodFlags.Virtual)
                            || method.Flags.HasFlag(MethodFlags.VirtualRequired)) continue;
                        godotClassType.Methods.RemoveAt(i);
                    }
                }
            }

            foreach (var godotClassType in godotTypeMap.SelectTypes(ClassDB.ApiType.Extension))
            {
                var logger = new GenerationLogger(godotClassType);
                var signalDefinitions = ClassDBAccess.ClassGetSignalList(godotClassType.GodotTypeName, true);
                foreach (var signalDefinition in signalDefinitions)
                {
                    var signalInfo = CreateFunctionInfo(godotTypeMap, signalDefinition, logger);
                    if (!exposeInternalMembers && signalInfo.GodotFunctionName.IsInternal()) continue;
                    godotClassType.Signals.Add(signalInfo);
                }
                if (logger.TryGetMessages(out var message)) warnings.Add(message);
            }

            foreach (var godotClassType in godotTypeMap.SelectTypes(ClassDB.ApiType.Extension))
            {
                var logger = new GenerationLogger(godotClassType);
                foreach (var enumType in godotClassType.Enums)
                {
                    if (godotClassType.Methods.All(x => x.CSharpFunctionName != enumType.CSharpTypeName)
                        && godotClassType.Properties.All(x => x.CSharpPropertyName != enumType.CSharpTypeName)
                        && godotClassType.Signals.All(x => x.CSharpFunctionName != enumType.CSharpTypeName)) continue;
                    enumType.UseAlias = true;
                }
                if (logger.TryGetMessages(out var message)) warnings.Add(message);
            }
        }

        private static GodotFunctionInfo CreateFunctionInfo(GodotTypeMap godotTypeMap, GodotDictionary methodDefinition, GenerationLogger logger)
        {
            var methodName = methodDefinition["name"].AsString();
            var flags = (MethodFlags)methodDefinition["flags"].AsInt64();
            var id = methodDefinition["id"].AsInt64();

            using var _ = logger.BeginScope(methodName);

            var returnValue = CreatePropertyInfo(methodDefinition["return"].AsGodotDictionary(), godotTypeMap, logger);

            var methodInfo = new GodotFunctionInfo(
                new(methodName),
                new(methodName.ToPascalCase()),
                returnValue,
                id,
                flags
            );

            var args = methodDefinition["args"].AsGodotArray<GodotDictionary>();

            var defaultArgs = methodDefinition["default_args"].AsGodotArray();
            var argsLength = args.Count;
            var defaultArgsLength = defaultArgs.Count;
            var defaultArgsStartIndex = argsLength - defaultArgsLength;

            for (var index = 0; index < argsLength; index++)
            {
                var methodArgumentInfo = args[index];
                var argument = CreatePropertyInfo(methodArgumentInfo, godotTypeMap, logger);
                if (index >= defaultArgsStartIndex)
                {
                    var defaultValue = defaultArgs[index - defaultArgsStartIndex];
                    methodInfo.FunctionArguments.Add(new(argument, defaultValue));
                }
                else
                {
                    methodInfo.FunctionArguments.Add(new(argument, null));
                }
            }

            return methodInfo;
        }


        private static GodotPropertyInfo CreatePropertyInfo(GodotDictionary propertyInfo, GodotTypeMap godotTypeMap, GenerationLogger logger)
        {
            var name = propertyInfo["name"].AsString();
            using var _ = logger.BeginScope(name);
            var className = propertyInfo["class_name"].AsString();
            var type = (Variant.Type)propertyInfo["type"].AsInt64();
            var hint = (PropertyHint)propertyInfo["hint"].AsInt64();
            var hintString = propertyInfo["hint_string"].AsString();
            var usage = (PropertyUsageFlags)propertyInfo["usage"].AsInt64();

            var propertyType = GetGodotTypeByPropertyDefinition(godotTypeMap, usage, new(string.IsNullOrEmpty(className) ? hintString : className), type, hint, hintString, name, logger);

            return new(new(name), new(name.ToCamelCase()), propertyType, hint, hintString, usage);
        }

        private static NormalizedEnumConstantsString NormalizeString(IEnumerable<string> sourceString) => string.Join(',', sourceString.Select(x => x.ToSnakeCase().ToUpperInvariant()).OrderBy(x => x));

        private static GodotType GetGodotTypeByPropertyDefinition(GodotTypeMap godotTypeMap, PropertyUsageFlags usage, GodotName className, Variant.Type type, PropertyHint hint, string hintString, string propertyName, GenerationLogger logger)
        {
            GodotType propertyType = godotTypeMap.Variant;

            if (hint is PropertyHint.Enum || usage.HasFlag(PropertyUsageFlags.ClassIsEnum))
            {
                var splits = className.String.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                GodotNamedType matchedEnumOwnerType = null;
                if (splits.Length == 2
                    && godotTypeMap.Types.TryGetValue(new(splits[0]), out matchedEnumOwnerType)
                    && godotTypeMap.PreregisteredEnumTypes.TryGetValue(matchedEnumOwnerType, out Dictionary<GodotName, GodotEnumType> preregisteredEnums)
                    && preregisteredEnums.TryGetValue(new(splits[1]), out var matchedEnumType)) propertyType = matchedEnumType;
                else if (godotTypeMap.GlobalScopeEnumTypes.TryGetValue(className, out var matchedGlobalScopeEnumType))
                    propertyType = matchedGlobalScopeEnumType;
                else if (godotTypeMap.TryGetVariantType(type, out var variantTypeAsEnumFallback))
                {
                    if (hintString.Contains(','))
                    {
                        var normalizedString = NormalizeString(hintString.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
                        if (godotTypeMap.PreregisteredEnumTypesByName.TryGetValue(normalizedString, out var candidates))
                        {
                            if (matchedEnumOwnerType != null)
                            {
                                if (candidates.TryGetValue(matchedEnumOwnerType, out var matchedEnumOwnerTypeCandidates))
                                {
                                    if (matchedEnumOwnerTypeCandidates.Count == 1)
                                    {
                                        propertyType = matchedEnumOwnerTypeCandidates.First().Value;
                                    }
                                    else
                                    {
                                        logger.Add($"Unable to disambiguate the supplied constant definition set [{hintString}] to one of the following enum definitions under the GodotType {matchedEnumOwnerType}: \n{string.Join("\n", matchedEnumOwnerTypeCandidates.Keys.Select(x => PrintIndent + PrintIndent + PrintIndent + x.String))}");
                                        propertyType = variantTypeAsEnumFallback;
                                    }
                                }
                                else
                                {
                                    logger.Add($"Unable to disambiguate the supplied constant definition set [{hintString}] to the declared enum type {matchedEnumOwnerType}, the supplied constant definition set have following enum types candidates: \n{string.Join(", ", candidates.Keys.Select(x => PrintIndent + PrintIndent + PrintIndent + x))}");
                                    propertyType = variantTypeAsEnumFallback;
                                }
                            }
                            else
                            {
                                if (candidates.Count == 1)
                                {
                                    var candidate = candidates.First();
                                    if (candidate.Value.Count == 1)
                                        propertyType = candidate.Value.First().Value;
                                    else
                                    {
                                        logger.Add($"Unable to disambiguate the supplied constant definition set [{hintString}] to one of the following enum definitions under type {candidate.Key}: \n{string.Join("\n", candidate.Value.Keys.Select(x => PrintIndent + PrintIndent + PrintIndent + x.String))}");
                                        propertyType = variantTypeAsEnumFallback;
                                    }
                                }
                                else
                                {
                                    logger.Add($"Unable to disambiguate the supplied constant definition set [{hintString}] to one of the following enum definitions: \n{string.Join("\n", candidates.SelectMany(type => type.Value.Select(enumName => $"{PrintIndent + PrintIndent + PrintIndent + type.Key}.{enumName.Key.String}")))}");
                                    propertyType = variantTypeAsEnumFallback;
                                }
                            }
                        }
                    }
                    else
                    {
                        logger.Add($"Using an enum constant definition set for property {propertyName} (\"{usage}\", \"{(string.IsNullOrEmpty(className.String) ? "Empty ClassName" : className)}\", \"{type}\", \"{hint}\", \"{(string.IsNullOrEmpty(hintString) ? "Empty Hint String" : hintString)}\").");
                        propertyType = new UserUndefinedEnumType(hintString, variantTypeAsEnumFallback);
                    }
                }
            }
            else if (type != Variant.Type.Object && godotTypeMap.TryGetVariantType(type, out var variantType))
            {
                propertyType = variantType;
            }
            else if (type is Variant.Type.Object)
            {
                if (godotTypeMap.Types.TryGetValue(className, out var matchedClassType))
                    propertyType = matchedClassType;
                else if (className.String.Contains(','))
                {
                    var classNameCandidates = className.String.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                    var candidateArray = new GodotType[classNameCandidates.Length];
                    var pass = true;
                    for (int i = 0; i < classNameCandidates.Length; i++)
                    {
                        var candidate = classNameCandidates[i];
                        if (godotTypeMap.Types.TryGetValue(new(candidate), out var candidateType))
                        {
                            candidateArray[i] = candidateType;
                        }
                        else
                        {
                            pass = false;
                            break;
                        }
                    }

                    if (pass) propertyType = new GodotMultiType(candidateArray, godotTypeMap.Variant);
                    else propertyType = godotTypeMap.Variant;
                }
            }
            else if (type is Variant.Type.Nil && usage.HasFlag(PropertyUsageFlags.NilIsVariant))
            {
                propertyType = godotTypeMap.Variant;
            }
            else if (type == Variant.Type.Array && hint == PropertyHint.ArrayType)
            {
                if (godotTypeMap.Types.TryGetValue(new(hintString), out var matchedArrayElementType))
                {
                    if (!godotTypeMap.PreregisteredArrayTypes.TryGetValue(matchedArrayElementType, out var arrayType))
                    {
                        arrayType = new(matchedArrayElementType);
                        godotTypeMap.PreregisteredArrayTypes.Add(matchedArrayElementType, arrayType);
                    }

                    propertyType = arrayType;
                }

                var regexMatch = ArrayDataRegex().Match(hintString);
                if (regexMatch.Success
                    && int.TryParse(regexMatch.Groups["arrayVariantType"].Value, out var arrayVariantTypeValue)
                    && int.TryParse(regexMatch.Groups["arrayVariantHint"].Value, out var arrayVariantHintValue))
                {
                    var arrayHintString = regexMatch.Groups["arrayHintString"].Value;
                    var arrayVariantType = (Variant.Type)arrayVariantTypeValue;
                    var arrayVariantHint = (PropertyHint)arrayVariantHintValue;

                    var elementType = GetGodotTypeByPropertyDefinition(godotTypeMap, PropertyUsageFlags.None, GodotName.Empty, arrayVariantType, arrayVariantHint, arrayHintString, propertyName, logger);

                    if (!godotTypeMap.PreregisteredArrayTypes.TryGetValue(elementType, out var arrayType))
                    {
                        arrayType = new(elementType);
                        godotTypeMap.PreregisteredArrayTypes.Add(elementType, arrayType);
                    }

                    propertyType = arrayType;
                }
            }
            else if (type == Variant.Type.Dictionary
                     && hint == PropertyHint.DictionaryType)
            {
                var regexMatch = DictionaryDataRegex().Match(hintString);
                if (regexMatch.Success
                    && int.TryParse(regexMatch.Groups["keyVariantType"].Value, out var keyVariantTypeValue)
                    && int.TryParse(regexMatch.Groups["keyVariantHint"].Value, out var keyVariantHintValue)
                    && int.TryParse(regexMatch.Groups["valueVariantType"].Value, out var valueVariantTypeValue)
                    && int.TryParse(regexMatch.Groups["valueVariantHint"].Value, out var valueVariantHintValue))
                {
                    var keyHintString = regexMatch.Groups["keyHintString"].Value;
                    var valueHintString = regexMatch.Groups["valueHintString"].Value;
                    var keyVariantType = (Variant.Type)keyVariantTypeValue;
                    var keyVariantHint = (PropertyHint)keyVariantHintValue;
                    var valueVariantType = (Variant.Type)valueVariantTypeValue;
                    var valueVariantHint = (PropertyHint)valueVariantHintValue;

                    var keyType = GetGodotTypeByPropertyDefinition(godotTypeMap, PropertyUsageFlags.None, GodotName.Empty, keyVariantType, keyVariantHint, keyHintString, propertyName, logger);
                    var valueType = GetGodotTypeByPropertyDefinition(godotTypeMap, PropertyUsageFlags.None, GodotName.Empty, valueVariantType, valueVariantHint, valueHintString, propertyName, logger);

                    if (!godotTypeMap.PreregisteredDictionaryTypes.TryGetValue((keyType, valueType), out var dictionaryType))
                    {
                        dictionaryType = new(keyType, valueType);
                        godotTypeMap.PreregisteredDictionaryTypes.Add((keyType, valueType), dictionaryType);
                    }

                    propertyType = dictionaryType;
                }
            }

            return propertyType;
        }

        [GeneratedRegex(@"(?<arrayVariantType>\d+)/(?<arrayVariantHint>\d+):(?<arrayHintString>\w+)")]
        private static partial Regex ArrayDataRegex();

        [GeneratedRegex(@"(?<keyVariantType>\d+)/(?<keyVariantHint>\d+):(?<keyHintString>\w+);(?<valueVariantType>\d+)/(?<valueVariantHint>\d+):(?<valueHintString>\w+)")]
        private static partial Regex DictionaryDataRegex();
    }
}
#endif
