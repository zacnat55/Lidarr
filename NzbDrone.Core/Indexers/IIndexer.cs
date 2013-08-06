using System;
using System.Collections.Generic;

namespace NzbDrone.Core.Indexers
{
    public interface IIndexer
    {
        string Name { get; }

        bool EnableByDefault { get; }

        IEnumerable<IndexerDefinition> DefaultDefinitions { get; }

        IndexerDefinition InstanceDefinition { get; set; }

        IEnumerable<string> RecentFeed { get; }

        IParseFeed Parser { get; }

        IEnumerable<string> GetEpisodeSearchUrls(string seriesTitle, int rageTvId, int seasonNumber, int episodeNumber);
        IEnumerable<string> GetDailyEpisodeSearchUrls(string seriesTitle, int rageTvId, DateTime date);
        IEnumerable<string> GetSeasonSearchUrls(string seriesTitle, int rageTvId, int seasonNumber);
        IEnumerable<string> GetPartialSeasonSearchUrls(string seriesTitle, int rageTvId, int seasonNumber, int episodeWildcard);
    }
}