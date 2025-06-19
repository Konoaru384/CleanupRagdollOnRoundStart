using System;

namespace Cleanup_Ragdoll_On_Start
{
    public abstract class Singleton<T>
    {
        private static T _instance;

        public static T Instance
        {
            get => _instance ?? (_instance = Activator.CreateInstance<T>());
            protected set => _instance = value;
        }
    }
}
