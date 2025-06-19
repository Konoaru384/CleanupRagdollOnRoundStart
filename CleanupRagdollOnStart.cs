using Exiled.API.Features;
namespace Cleanup_Ragdoll_On_Start
{
    public class CleanupRagdollOnStart : Plugin<Config>
    {
        public override string Name { get; } = "CleanupRagdollOnStartBetterThisTime";

        public override string Prefix { get; } = "CROSBT";

        public override string Author { get; } = "Konoaru & Lanonymous";

        public static CleanupRagdollOnStart Instance { get; private set; } = null;

        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Server.RoundStarted += EventHandler.RoundStartEvent.Instance.OnRoundStart;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandler.RoundStartEvent.Instance.OnRoundStart;
            Instance = null;
            base.OnDisabled();
        }
    }
}
