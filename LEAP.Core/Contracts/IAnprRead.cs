using System;
using LEAP.Core.Components;
using LEAP.Core.Types;

namespace LEAP.Core.Contracts
{
    public interface IAnprRead
    {
        Guid Id { get; }
        DateTime CaptureTime { get; }

        string PlateText { get; }
        AnprReadVehicleViewTypes View { get; }

        double Confidence { get; }
        double[] CharacterConfidence { get; }

        GeoSummary? Location { get; }
        Guid? LocationId { get; }
        
        string PatchImage { get; }
        RectangularPoint PatchSize { get; }

        string ResultImage { get; }
        RectangularPoint ResultSize { get; }
        RectangularQuadrilateral? ResultPatchRegion { get; }
        
        string[] OverviewImages { get; }
        
        string Notes { get; }

        IAnprReadEngineSummary Engine { get; }
        IAnprReadSource Source { get; }
        IAnprReadCorrection Correction { get; }
    }
}