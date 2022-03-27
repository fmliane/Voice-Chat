using UnityEngine;

namespace VoiceChat.Util
{
    public class PermissionHandler : MonoBehaviour
    {
        void Awake()
        {
            PermissionRequestHelper.RequestMicrophonePermission();
        }
    }
}
