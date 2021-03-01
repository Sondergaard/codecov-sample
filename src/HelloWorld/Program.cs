using System;

namespace HelloWorld
{
    class Program
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

        private void SayHello()
        {
            _writer.WriteLine("Hello world");
        }
    }


    internal interface ITextWriter
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
