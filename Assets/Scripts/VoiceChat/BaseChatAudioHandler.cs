using UnityEngine;
using VoiceChat.Util;

namespace VoiceChat
{
    public abstract class BaseChatAudioHandler : MonoBehaviour, IVoiceChannelHandler
    {
        public virtual void VoiceChannelCallback()
        {
            Debug.Log("Engine initialized and ready.");
        }

        public virtual void JoinVoiceChannel()
        {
            if (VoiceChatHelper.Engine == null)
            {
                return;
            }
        }

        public virtual void LeaveVoiceChannel()
        {
            if (VoiceChatHelper.Engine == null)
            {
                return;
            }
        }
    }
}
