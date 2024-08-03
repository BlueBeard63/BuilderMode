using Rocket.API;

namespace BuilderMode
{
    public class Config : IRocketPluginConfiguration
    {
        public bool EnableServerAnnouncer;
        public float RestrictiveDistance;
        public float MinY;
        public float MaxY;
        public string MessageColor;
        public void LoadDefaults()
        {
            EnableServerAnnouncer = true;
            RestrictiveDistance = 50f;
            MinY = -20f;
            MaxY = 400f;
            MessageColor = "Yellow";
        }
    }
}
