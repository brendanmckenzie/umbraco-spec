using System.Configuration;

namespace Umbraco.Spec.Config
{
    public class UmbracoSpecConfig : ConfigurationSection
    {
        private static readonly UmbracoSpecConfig _current = ConfigurationManager.GetSection("umbracoSpec") as UmbracoSpecConfig;

        /// <summary>
        /// Gets the current configuration.
        /// </summary>
        /// <value>
        /// The current configuration.
        /// </value>
        public static UmbracoSpecConfig Current
        {
            get { return _current; }
        }

        /// <summary>
        /// Gets a value indicating whether this Umbraco.Spec is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        [ConfigurationProperty("enabled", IsRequired = true)]
        public virtual bool Enabled { get { return (bool)this["enabled"]; } }

        /// <summary>
        /// Gets the path to the configuration file.
        /// </summary>
        /// <value>
        /// The path to the configuration file.
        /// </value>
        [ConfigurationProperty("configFile", IsRequired = true)]
        public virtual string ConfigFile { get { return (string)this["configFile"]; } }
    }
}
