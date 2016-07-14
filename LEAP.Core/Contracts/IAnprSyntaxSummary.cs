using System;

namespace LEAP.Core.Contracts
{
    public interface IAnprSyntaxSummary
    {
        Guid SyntaxId { get; }
        string SyntaxName { get; }
        string SyntaxDescription { get; }
        string SyntaxVersion { get; }
    }
}