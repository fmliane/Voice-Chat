using UnityEngine;
#if UNITY_ANDROID
using UnityEngine.Android;
#endif

namespace VoiceChat.Util
{
	public class PermissionRequestHelper
	{
		public static void RequestMicrophonePermission()
		{
#if (UNITY_2018_3_OR_NEWER && UNITY_ANDROID)
			if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
			{
				Permission.RequestUserPermission(Permission.Microphone);
			}
#endif
		}
	}
}
