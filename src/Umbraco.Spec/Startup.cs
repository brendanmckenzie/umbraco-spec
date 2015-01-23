using Newtonsoft.Json;
using System.IO;
using Umbraco.Spec.Config;

namespace Umbraco.Spec
{
    public class Startup
    {
        /// <summary>
        /// Entry-point for the Umbraco.Spec application.  Call this from the startup method of your application.
        /// </summary>
        public void Configuration()
        {
            if (UmbracoSpecConfig.Current == null || !UmbracoSpecConfig.Current.Enabled) { return; }

            var configFile = UmbracoSpecConfig.Current.ConfigFile;

            var configContent = File.ReadAllText(configFile);

            var config = JsonConvert.DeserializeObject(configContent);

            // let the games begin.
        }
    }
}
