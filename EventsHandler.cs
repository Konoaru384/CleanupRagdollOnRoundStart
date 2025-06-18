using Exiled.API.Features;
using ServerEvents = Exiled.Events.Handlers.Server;

namespace CleanupRagdollOnStart
{
    public class EventsHandler
    {
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

