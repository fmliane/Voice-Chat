using UnityEngine;

namespace VoiceChat.Group
{
    public class GroupVoiceChannel : BaseChatAudioHandler
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
