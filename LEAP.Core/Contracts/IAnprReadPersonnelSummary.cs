using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadPersonnelSummary
    {
        Guid Id { get; }
        string Name { get; } 
    }
}