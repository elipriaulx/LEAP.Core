using System;
using System.Collections.Generic;
using LEAP.Core.Types;

namespace LEAP.Core.Contracts
{
    public interface IAnprRead
    {
        Guid Id { get; }
        DateTime Captured { get; }

        string PlateText { get; }
        AnprReadVehicleViewTypes VehicleView { get; }

        double Confidence { get; }
        IEnumerable<double> CharacterConfidence { get; }

        GeoSummary? Location { get; }
        Guid? LocationId { get; }
        
        string PatchImageString { get; }
        RectangularPoint PatchSize { get; }

        string ResultImageString { get; }
        RectangularPoint ResultSize { get; }
        RectangularQuadrilateral? ResultPatchRegion { get; }
        RectangularQuadrilateral? ResultPatchArea { get; }

        IEnumerable<string> OverviewImageStrings { get; }
        
        IEnumerable<IAnprReadNote> Notes { get; }

        IEnumerable<IAnprReadTag> Tags { get; }

        IAnprEngineSummary Engine { get; }
        IAnprSyntaxSummary Syntax { get; }
        IAnprReadSource Source { get; }
        IAnprReadCorrection Correction { get; }

        IEnumerable<KeyValuePair<string, string>> Meta { get; }
    }
}