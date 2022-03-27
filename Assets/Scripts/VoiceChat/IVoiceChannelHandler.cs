namespace VoiceChat.Util
{
    public interface IVoiceChannelHandler
    {
        public void VoiceChannelCallback();
        public void JoinVoiceChannel();
        public void LeaveVoiceChannel();
    }
}
