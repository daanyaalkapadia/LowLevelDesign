using PracticalDesign.Pen.Enums;
using PracticalDesign.Pen.PenParts;
using PracticalDesign.Pen.WritingStrategy;

namespace PracticalDesign.Pen.PenTypes
{
    internal class GelPen : Pen
    {
        public GelPen()
        {
            Type = PenType.Gel;
        }
        public Refil Refil { get; set; } = new Refil();
        private IWritingStrategy _writingStrategy = new DefaultWritingStrategy();
        public override void SetStrategy(IWritingStrategy writingStrategy)
        {
            _writingStrategy = writingStrategy;
        }

        public override void Write()
        {
            _writingStrategy.Write();
        }
    }
}
