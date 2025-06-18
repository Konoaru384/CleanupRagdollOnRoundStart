using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CleanupRagdollOnStart
{
    public class Config : IConfig
    {
        [Description("Should cleanup on start is enabled ?")]
        public bool IsEnabled { get; set; } = true;
        [Description("There is actualy no debug on this plugin... sorry !.")]
        public bool Debug { get; set; } = false;
    }
}