#pragma warning disable CS0109
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Godot;
using Godot.Collections;

namespace GDExtension.Wrappers;

[Tool]
public partial class SteamPacketPeer : PacketPeerExtension
{

    private new static readonly StringName NativeName = new StringName("SteamPacketPeer");

    [Obsolete("Wrapper types cannot be constructed with constructors (it only instantiate the underlying SteamPacketPeer object), please use the Instantiate() method instead.")]
    protected SteamPacketPeer() { }

    private static CSharpScript _wrapperScriptAsset;

    /// <summary>
    /// Try to cast the script on the supplied <paramref name="godotObject"/> to the <see cref="SteamPacketPeer"/> wrapper type,
    /// if no script has attached to the type, or the script attached to the type does not inherit the <see cref="SteamPacketPeer"/> wrapper type,
    /// a new instance of the <see cref="SteamPacketPeer"/> wrapper script will get attaches to the <paramref name="godotObject"/>.
    /// </summary>
    /// <remarks>The developer should only supply the <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</remarks>
    /// <param name="godotObject">The <paramref name="godotObject"/> that represents the correct underlying GDExtension type.</param>
    /// <returns>The existing or a new instance of the <see cref="SteamPacketPeer"/> wrapper script attached to the supplied <paramref name="godotObject"/>.</returns>
    public new static SteamPacketPeer Bind(GodotObject godotObject)
    {
        if (!IsInstanceValid(godotObject))
            return null;

        if (godotObject is SteamPacketPeer wrapperScriptInstance)
            return wrapperScriptInstance;

#if DEBUG
        var expectedType = typeof(SteamPacketPeer);
        var currentObjectClassName = godotObject.GetClass();
        if (!ClassDB.IsParentClass(expectedType.Name, currentObjectClassName))
            throw new InvalidOperationException($"The supplied GodotObject ({currentObjectClassName}) is not the {expectedType.Name} type.");
#endif

        if (_wrapperScriptAsset is null)
        {
            var scriptPathAttribute = typeof(SteamPacketPeer).GetCustomAttributes<ScriptPathAttribute>().FirstOrDefault();
            if (scriptPathAttribute is null) throw new UnreachableException();
            _wrapperScriptAsset = ResourceLoader.Load<CSharpScript>(scriptPathAttribute.Path);
        }

        var instanceId = godotObject.GetInstanceId();
        godotObject.SetScript(_wrapperScriptAsset);
        return (SteamPacketPeer)InstanceFromId(instanceId);
    }

    /// <summary>
    /// Creates an instance of the GDExtension <see cref="SteamPacketPeer"/> type, and attaches a wrapper script instance to it.
    /// </summary>
    /// <returns>The wrapper instance linked to the underlying GDExtension "SteamPacketPeer" type.</returns>
    public new static SteamPacketPeer Instantiate() => Bind(ClassDB.Instantiate(NativeName).As<GodotObject>());

    public enum PeerState
    {
        None = 0,
        Connecting = 1,
        FindingRoute = 2,
        Connected = 3,
        StateClosedByPeer = 4,
        ProblemDetectedLocally = 5,
        FinWait = -1,
        Linger = -2,
        Dead = -3,
    }

    public new static class GDExtensionMethodName
    {
        public new static readonly StringName GetSteamId = "get_steam_id";
        public new static readonly StringName GetConnectionHandle = "get_connection_handle";
        public new static readonly StringName GetPeerId = "get_peer_id";
        public new static readonly StringName GetState = "get_state";
        public new static readonly StringName DisconnectPeer = "disconnect_peer";
    }

    public new long GetSteamId() => 
        Call(GDExtensionMethodName.GetSteamId, []).As<long>();

    public new long GetConnectionHandle() => 
        Call(GDExtensionMethodName.GetConnectionHandle, []).As<long>();

    public new long GetPeerId() => 
        Call(GDExtensionMethodName.GetPeerId, []).As<long>();

    public new SteamPacketPeer.PeerState GetState() => 
        Call(GDExtensionMethodName.GetState, []).As<SteamPacketPeer.PeerState>();

    public new void DisconnectPeer(bool force = false) => 
        Call(GDExtensionMethodName.DisconnectPeer, [force]);

}
