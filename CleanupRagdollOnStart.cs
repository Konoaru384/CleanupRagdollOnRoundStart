using Exiled.API.Features;

namespace CleanupRagdollOnStart
{
    public class CustomSpawnForKonoara : Plugin<Config>
    {
        private EventsHandler _eventsHandler;

        public override string Name { get; } = "CleanupRagdollOnStart";

        public override string Prefix { get; } = "CleanupRagdollOnStart";

        public override string Author { get; } = "Konoaru";

        public override void OnEnabled()
        {
            _eventsHandler = new EventsHandler(this);
            _eventsHandler.Register();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            if (_eventsHandler != null) _eventsHandler.Unregister();
            base.OnDisabled();
        }
    }
}