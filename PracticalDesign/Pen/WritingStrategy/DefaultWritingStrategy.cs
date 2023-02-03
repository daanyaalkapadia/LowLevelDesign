namespace PracticalDesign.Pen.WritingStrategy
{
    internal class DefaultWritingStrategy : IWritingStrategy
    {
        public void Write()
        {
            Console.WriteLine("We are writing with default writing strategy");
        }
    }
}
