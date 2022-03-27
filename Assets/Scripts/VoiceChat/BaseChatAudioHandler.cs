using UnityEngine;
using VoiceChat.Util;

namespace VoiceChat
{
    public abstract class BaseChatAudioHandler : MonoBehaviour, IVoiceChannelHandler
    {
        //Placeholder variables
        //For testing purposes only
        //todo[Li] Add this in a separate scriptableObject and find a way to generate tokens from agora console
        [SerializeField] private string token = "";
        [SerializeField] private string roomName = "";

        public virtual void VoiceChannelCallback()
        {
            VoiceChatHelper.GetRTCEngine().OnJoinChannelSuccess += OnJoinChannelSuccessHandler;
            VoiceChatHelper.GetRTCEngine().OnUserJoined += OnUserJoined;
            Debug.Log("Engine initialized and ready.");
        }

        /// <summary>
        /// Creates Hub Channel if initialized first time, remote player automatically joins channel if channel exist
        /// <param name="channelName"> has a temporary value.</param>
        /// <param name="channelKey"> generated token in agora console using appid.</param>
        /// The parameters should come from Quantum Client and will be set upon entering the Bootstrap.scene. 
        /// </summary>
        public virtual void JoinVoiceChannel()
        {
            if (VoiceChatHelper.Engine == null)
            {
                return;
            }

            VoiceChannelCallback();

            VoiceChatHelper.GetRTCEngine().JoinChannelByKey(channelKey: token, channelName: roomName);
        }

        public virtual void LeaveVoiceChannel()
        {
            if (VoiceChatHelper.Engine == null)
            {
                return;
            }

            VoiceChatHelper.GetRTCEngine().LeaveChannel();
        }

        public virtual void OnJoinChannelSuccessHandler(string channelName, uint uID, int elapsed)
        {
            Debug.Log("Successfullly Joined Channel : " + uID);
        }

        public virtual void OnUserJoined(uint uID, int elapsed)
        {
            Debug.Log("Player UID " + uID + "  has joined the Channel.");
        }
    }
}
