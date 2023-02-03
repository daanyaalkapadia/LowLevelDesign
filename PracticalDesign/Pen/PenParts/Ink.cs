using PracticalDesign.Pen.Enums;

namespace PracticalDesign.Pen.PenParts
{
    internal class Ink
    {
        public List<InkFeature> Features { get; set; } = new List<InkFeature>();
        public string Color { get; set; } = String.Empty;
    }
}
