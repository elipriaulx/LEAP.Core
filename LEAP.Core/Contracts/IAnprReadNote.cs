using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadNote
    {
        DateTime Created { get; }
        IAnprPersonnelSummary Reporter { get; } 
        string Note { get; }
    }
}