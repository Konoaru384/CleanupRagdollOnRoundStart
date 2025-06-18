using Exiled.API.Features;
using ServerEvents = Exiled.Events.Handlers.Server;

namespace CleanupRagdollOnStart
{
    public class EventsHandler
    {
        internal EventsHandler plugin;
        private CustomSpawnForKonoara customSpawnForKonoara;

        public EventsHandler(EventsHandler plugin)
        {
            this.plugin = plugin;
        }

        public EventsHandler(CustomSpawnForKonoara customSpawnForKonoara)
        {
            this.customSpawnForKonoara = customSpawnForKonoara;
        }

        private void Cleaning()
        {
            Map.CleanAllRagdolls();
        }


        public void Register()
        {
            ServerEvents.RoundStarted += OnRoundStarted;
        }

        public void Unregister()
        {
            ServerEvents.RoundStarted -= OnRoundStarted;
        }

        internal void OnRoundStarted()
        {
            Cleaning();
        }
    }
}
