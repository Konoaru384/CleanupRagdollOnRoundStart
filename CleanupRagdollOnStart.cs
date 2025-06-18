using Exiled.API.Features;
namespace Cleanup_Ragdoll_On_Start
{
    public class CleanupRagdollOnStart : Plugin<Config>
    {
        public override string Name { get; } = "CleanupRagdollOnStartBetterThisTime";

        public override string Prefix { get; } = "CROSBT";

        public override string Author { get; } = "Konoaru & Lanonymous";

        // Create a plugin instance for easy config access, the null check isn't necessary but it's a good practice to avoid null reference exceptions.
        public static CleanupRagdollOnStart Instance { get; private set; } = null;

        // Subscribe for events here, you could do an event manager class if you want to keep things organized.
        public override void OnEnabled()
        {
            // Instance this plugin so we can access it from anywhere.
            Instance = this;
            Exiled.Events.Handlers.Server.RoundStarted += EventHandler.RoundStartEvent.Instance.OnRoundStart;
            base.OnEnabled();
        }

        // Unsubscribe from events here, you could do an event manager class if you want to keep things organized.
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandler.RoundStartEvent.Instance.OnRoundStart;
            // Set the instance to null to allow for garbage collection and avoid memory leaks.
            Instance = null;
            base.OnDisabled();
        }
    }
}