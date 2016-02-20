using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadEngineSummary
    {
        Guid EngineId { get; }
        string EngineName { get; set; }
        string EngineVersion { get; }

        Guid SyntaxId { get; }
        string SyntaxName { get; set; }
        string SyntaxVersion { get; set; }
    }
}