﻿using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace AdultEmby.Plugins.DorcelVision
{
    class DorcelVision : BasePlugin<DorcelVisionConfiguration>
    {
        public DorcelVision(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            //AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainOnAssemblyResolve;
        }

        public override string Name => DorcelVisionConstants.ProviderName;

        public override string Description => "Gets metadata for adult movies from dorcelvision.com";
    }

    public class DorcelVisionConfiguration : BasePluginConfiguration
    {
    }

    public class DorcelVisionConstants
    {
        public const string BaseUrl = "https://www.dorcelvision.com/";

        public const string ProviderName = "Dorcel Vision";

        public const string RootFileCacheName = "dorcelvision";

        public const string PeopleFileCacheName = "people";

        public const string MovieFileCacheName = "movies";

        public const string ContentFileCacheName = "content";

        //public const string CacheItemName = "item.html";
    }
}
