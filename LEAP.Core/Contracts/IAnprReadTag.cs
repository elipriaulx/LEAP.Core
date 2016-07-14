using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadTag
    {
        Guid Id { get; }
        string Name { get; }
        string Description { get; }
    }
}
