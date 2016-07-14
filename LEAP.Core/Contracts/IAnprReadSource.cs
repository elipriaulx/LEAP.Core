using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadSource
    {
        Guid DeviceId { get; }
        string DeviceName { get; }

        Guid LaneId { get; }
        string LaneName { get; }

        Guid ZoneId { get; }
        string ZoneName { get; }
        
        Guid SiteId { get; }
        string SiteName { get; }

        Guid CollectionId { get; }
        string CollectionName { get; }
    }
}