namespace PracticalDesign.Pen.PenParts
{
    internal class Refil
    {
        public Ink Ink { get; set; } = new Ink();
        public Nib Nib { get; set; } = new Nib();
        public int Price { get; set; }
    }
}
