using UnityEngine;

namespace VoiceChat.Util
{
    [CreateAssetMenu(menuName = "Scriptable Objects/App Config")]
    public class AppConfigScriptableObject : ScriptableObject
    {
        [SerializeField] private string appId;

        public string AppId => appId;
    }
}
