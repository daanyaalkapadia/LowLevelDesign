using PracticalDesign.Pen.Enums;
using PracticalDesign.Pen.WritingStrategy;

namespace PracticalDesign.Pen
{
    internal abstract class Pen
    {
        public string Name { get; set; } = String.Empty;
        public string? Brand { get; set; }
        public int Price { get; set; }
        public PenType Type { get; set; }
        public abstract void Write();
        public abstract void SetStrategy(IWritingStrategy writingStrategy);
        public static Pen GetPen(PenType type)
        {
            return PenFactory.GetPen(type);
        }
    }
}
