using UnityEngine;
using UnityEngine.SceneManagement;
using VoiceChat.Util;

namespace VoiceChat
{
    public class ChatAudioInitializer : MonoBehaviour
    {
        [SerializeField] private AppConfigScriptableObject appConfig;

        #region Test Methods For Voice Coms
        public void LoadHudScene()
        {
            SceneManager.LoadScene(1);
        }

        public void DestroyActiveEngine()
        {
            if (VoiceChatHelper.Engine != null)
            {
                VoiceChatHelper.DestroyActiveEngine();
                VoiceChatHelper.Engine = null;
                Debug.Log("Unload active engine.");
            }
        }

        public void ReinitializeEngine()
        {
            VoiceChatHelper.InitializeEngine(appConfig.AppId);
        }
        #endregion

        private void InitializeVoiceEngine()
        {
            VoiceChatHelper.InitializeEngine(appConfig.AppId);
            Debug.Log($"Using agora developer id: {appConfig.AppId}");
        }

        private void Awake()
        {
            InitializeVoiceEngine();
        }
    }
}
