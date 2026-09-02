#pragma warning disable CS0109
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Godot;
using Godot.Collections;

namespace GDExtension.Wrappers;

[Tool]
public partial class SteamMultiplayerPeer : MultiplayerPeerExtension
{

    private new static readonly StringName NativeName = new StringName("SteamMultiplayerPeer");

    [Obsolete("Wrapper types cannot be constructed with constructors (it only instantiate the underlying SteamMultiplayerPeer object), please use the Instantiate() method instead.")]
    protected SteamMultiplayerPeer() { }

    private static CSharpScript _wrapperScriptAsset;

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="SteamMultiplayerPeer"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="SteamMultiplayerPeer"/> wrapper type,
    /// a new instance of the <see cref="SteamMultiplayerPeer"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="SteamMultiplayerPeer"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public new static SteamMultiplayerPeer Bind(GodotObject godotObject)
    {
        if (!IsInstanceValid(godotObject))
            return null;

        if (godotObject is SteamMultiplayerPeer wrapperScriptInstance)
            return wrapperScriptInstance;

#if DEBUG
        var expectedType = typeof(SteamMultiplayerPeer);
        var currentObjectClassName = godotObject.GetClass();
        if (!ClassDB.IsParentClass(expectedType.Name, currentObjectClassName))
            throw new InvalidOperationException($"The supplied GodotObject ({currentObjectClassName}) is not the {expectedType.Name} type.");
#endif

        if (_wrapperScriptAsset is null)
        {
            var scriptPathAttribute = typeof(SteamMultiplayerPeer).GetCustomAttributes<ScriptPathAttribute>().FirstOrDefault();
            if (scriptPathAttribute is null) throw new UnreachableException();
            _wrapperScriptAsset = ResourceLoader.Load<CSharpScript>(scriptPathAttribute.Path);
        }

        var instanceId = godotObject.GetInstanceId();
        godotObject.SetScript(_wrapperScriptAsset);
        return (SteamMultiplayerPeer)InstanceFromId(instanceId);
    }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="SteamMultiplayerPeer"/> type, and attaches a wrapper script instance to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension "SteamMultiplayerPeer" type.</returns>
    public new static SteamMultiplayerPeer Instantiate() => Bind(ClassDB.Instantiate(NativeName).As<GodotObject>());

    public enum DebugLevelEnum
    {
        None = 0,
        Peer = 1,
        Steam = 2,
    }

    public new static class GDExtensionPropertyName
    {
        public new static readonly StringName NoDelay = "no_delay";
        public new static readonly StringName NoNagle = "no_nagle";
        public new static readonly StringName ServerRelay = "server_relay";
        public new static readonly StringName DebugLevel = "debug_level";
    }

    public new bool NoDelay
    {
        get => Get(GDExtensionPropertyName.NoDelay).As<bool>();
        set => Set(GDExtensionPropertyName.NoDelay, value);
    }

    public new bool NoNagle
    {
        get => Get(GDExtensionPropertyName.NoNagle).As<bool>();
        set => Set(GDExtensionPropertyName.NoNagle, value);
    }

    public new bool ServerRelay
    {
        get => Get(GDExtensionPropertyName.ServerRelay).As<bool>();
        set => Set(GDExtensionPropertyName.ServerRelay, value);
    }

    public new SteamMultiplayerPeer.DebugLevelEnum DebugLevel
    {
        get => Get(GDExtensionPropertyName.DebugLevel).As<SteamMultiplayerPeer.DebugLevelEnum>();
        set => Set(GDExtensionPropertyName.DebugLevel, Variant.From(value));
    }

    public new static class GDExtensionMethodName
    {
        public new static readonly StringName CreateHost = "create_host";
        public new static readonly StringName CreateClient = "create_client";
        public new static readonly StringName AddPeer = "add_peer";
        public new static readonly StringName GetPeer = "get_peer";
        public new static readonly StringName HostWithLobby = "host_with_lobby";
        public new static readonly StringName ConnectToLobby = "connect_to_lobby";
        public new static readonly StringName GetSteamIdForPeerId = "get_steam_id_for_peer_id";
        public new static readonly StringName GetPeerIdForSteamId = "get_peer_id_for_steam_id";
    }

    public new Error CreateHost(long virtualPort = 0) => 
        Call(GDExtensionMethodName.CreateHost, [virtualPort]).As<Error>();

    public new Error CreateClient(long steamId, long virtualPort = 0) => 
        Call(GDExtensionMethodName.CreateClient, [steamId, virtualPort]).As<Error>();

    public new Error AddPeer(long steamId, long virtualPort = 0) => 
        Call(GDExtensionMethodName.AddPeer, [steamId, virtualPort]).As<Error>();

    public new SteamPacketPeer GetPeer(long peerId) => 
        SteamPacketPeer.Bind(Call(GDExtensionMethodName.GetPeer, [peerId]).As<PacketPeerExtension>());

    public new Error HostWithLobby(long lobbyId) => 
        Call(GDExtensionMethodName.HostWithLobby, [lobbyId]).As<Error>();

    public new Error ConnectToLobby(long lobbyId) => 
        Call(GDExtensionMethodName.ConnectToLobby, [lobbyId]).As<Error>();

    public new long GetSteamIdForPeerId(long peerId) => 
        Call(GDExtensionMethodName.GetSteamIdForPeerId, [peerId]).As<long>();

    public new long GetPeerIdForSteamId(long steamId) => 
        Call(GDExtensionMethodName.GetPeerIdForSteamId, [steamId]).As<long>();

}
