using PracticalDesign.Pen.WritingStrategy;

namespace PracticalDesign.Pen
{
    internal class Client
    {
        public static void ClientPen()
        {
            Pen pen = Pen.GetPen(Enums.PenType.Gel);
            pen.SetStrategy(new TrimaxWriteStrategy());
            pen.Write();
        }
    }
}
