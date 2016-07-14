using System;
using System.Collections.Generic;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadBatch
    {
        Guid Id { get; }
        string Name { get; }
        string Description { get; } 

        DateTime Created { get; }
        DateTime Updated { get; }

        IEnumerable<IAnprRead> Reads { get; }
    }
}