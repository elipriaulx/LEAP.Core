using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprPersonnelSummary
    {
        Guid Id { get; }
        string DisplayName { get; }
        string Description { get; }
    }
}