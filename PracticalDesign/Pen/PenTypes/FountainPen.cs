using PracticalDesign.Pen.Enums;
using PracticalDesign.Pen.PenParts;
using PracticalDesign.Pen.WritingStrategy;

namespace PracticalDesign.Pen.PenTypes
{
    internal class FountainPen : Pen
    {
        public FountainPen()
        {
            Type = PenType.Fountain;
        }
        public Ink Ink { get; set; } = new Ink();
        public Nib Nib { get; set; } = new Nib();
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
