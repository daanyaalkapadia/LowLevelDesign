using PracticalDesign.Pen.Enums;
using PracticalDesign.Pen.PenTypes;

namespace PracticalDesign.Pen
{
    internal class PenFactory
    {
        public static Pen GetPen(PenType type)
        {
            switch (type)
            {
                case PenType.Ball:
                    return new BallPen();
                case PenType.Gel:
                    return new GelPen();
                case PenType.Fountain:
                    return new FountainPen();
                default:
                    throw new NotSupportedException("PenType Not Supported");
            }
        }
    }
}
