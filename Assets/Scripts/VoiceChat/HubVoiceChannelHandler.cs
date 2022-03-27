using UnityEngine;

namespace VoiceChat.Hub
{
    public class HubVoiceChannelHandler : BaseChatAudioHandler
    {
        public override void JoinVoiceChannel()
        {
            Debug.Log("Joined Voice Hub Channel.");
            base.JoinVoiceChannel();
        }

        public override void LeaveVoiceChannel()
        {
            Debug.Log("Leave Voice Hub Channel.");
            base.LeaveVoiceChannel();
        }
    }
}
