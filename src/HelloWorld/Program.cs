namespace HelloWorld
{
    public class Program
    {
        private readonly ITextWriter _writer;

        public Program(ITextWriter writer)
        {
            _writer = writer;
        }
        
        static void Main(string[] args)
        {
            var prg = new Program(new ConsoleTextWriter());
            prg.SayHello();
        }

        public void SayHello()
        {
            _writer.WriteLine("Hello world");
        }
    }
}
