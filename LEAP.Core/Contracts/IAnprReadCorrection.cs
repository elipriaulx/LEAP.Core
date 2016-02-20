using System;
using LEAP.Core.Types;

namespace LEAP.Core.Contracts
{
    public interface IAnprReadCorrection
    {
        DateTime Date { get; set; }

        string OriginalText { get; }
        string CorrectedText { get; }

        AnprReadCorrectionStatusTypes Status { get; }
        string Description { get; }

        IAnprReadPersonnelSummary User { get; }
    }
}