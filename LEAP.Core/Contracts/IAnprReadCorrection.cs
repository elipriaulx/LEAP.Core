using System;
using LEAP.Core.Types;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadCorrection
    {
        DateTime CorrectionDate { get; }

        string OriginalText { get; }
        string CorrectedText { get; }

        AnprReadCorrectionStatusTypes Status { get; }
        string Description { get; }

        IAnprPersonnelSummary User { get; }
    }
}