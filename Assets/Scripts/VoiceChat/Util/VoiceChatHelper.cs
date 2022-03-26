using UnityEngine;
using agora_gaming_rtc;

/// <summary>
/// Wrapper for Agora Voice SDK 
/// </summary>

namespace VoiceChat.Util
{
    public static class VoiceChatHelper
    {
        public static IRtcEngine Engine;

        public static IRtcEngine GetRTCEngine()
        {
            if (Engine != null)
            {
                return Engine;
            }
            Debug.LogError("Trying to get Engine before it is initialized, returning null");
            return null;
        }

        public static void InitializeEngine(string appId)
        {
            Engine = IRtcEngine.GetEngine(appId);
        }

        public static void DestroyActiveEngine()
        {
            IRtcEngine.Destroy();
        }

        public static void LeaveActiveChannel()
        {
            Engine.LeaveChannel();
        }


        /// <summary>
        /// Joins a channel with unique id and subscribes to voice stream. 
        /// <param name="channelName"> a string value is passed to reference as the channelName.</param>
        /// <param name="info"> can contain user info .</param>
        /// <param name="uid"> unique identifier for user when joined.</param>
        /// </summary>
        public static void PlayerJoinChannel(string channelName, string info, uint uid)
        {
            Engine.JoinChannel(channelName, info, uid);
        }
    }
}
