using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprEngineSummary
    {
        Guid EngineId { get; }
        string EngineName { get; }
        string EngineDescription { get; }
        string EngineVersion { get; }
    }
}