namespace LEAP.Core.Types
{
    public struct RectangularQuadrilateral
    {
        public RectangularPoint TopLeft { get; set; }
        public RectangularPoint TopRight { get; set; }
        public RectangularPoint BottomLeft { get; set; }
        public RectangularPoint BottomRight { get; set; }
    }
}