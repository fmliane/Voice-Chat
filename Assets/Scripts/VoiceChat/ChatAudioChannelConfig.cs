using UnityEngine;

namespace VoiceChat.Util
{
    public class ChatAudioChannelConfig : MonoBehaviour
    {
        public void SetVoiceChannelAudioConfig()
        {
            //Will allow switching loudspeaker to bluetooth earbuds
            VoiceChatHelper.AllowAudioVolumeIndication(200, 4, true);
            VoiceChatHelper.PlayAudioOnSpeakerphone(true);
            // Taken from: https://docs.agora.io/en/Voice/faq/no_music_Unity_objects
            VoiceChatHelper.GetRTCEngine().SetParameters("{\"che.audio.keep.audiosession\":true}");
        }
    }
}
