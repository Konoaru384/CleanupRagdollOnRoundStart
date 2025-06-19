using Exiled.API.Features;

namespace Cleanup_Ragdoll_On_Start.EventHandler
{
    public class RoundStartEvent : Singleton<RoundStartEvent>
    {
        public void OnRoundStart()
        {
            Cleaning();
        }

        public static void Cleaning()
        {
            Map.CleanAllRagdolls();
            Log.Debug("Ragdolls cleared.");
        }
    }
}