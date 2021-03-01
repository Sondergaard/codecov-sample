using System;

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


    public interface ITextWriter
    {
        void WriteLine(string lineToWrite);
    }

    internal class ConsoleTextWriter : ITextWriter
    {
        public void WriteLine(string lineToWrite)
        {
            Console.WriteLine(lineToWrite);
        }
    }
    
}
