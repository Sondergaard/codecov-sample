using System;
using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_only_write_once()
        {
            var mockWriter = new Mock<ITextWriter>();
            var prg = new Program(mockWriter.Object);
            
            prg.SayHello();
            
            mockWriter.Verify(m => m.WriteLine(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void Should_handle_null_values()
        {
            var sut = new ConsoleTextWriter();
            sut.WriteLine(null);
        }

        [Fact]
        public void Should_handle_input_of_1024_chars()
        {
            var sut = new ConsoleTextWriter();
            var input = new string('x', 1024);
            
            sut.WriteLine(input);
        }

        [Fact]
        public void ExecuteProgram_Should_Not_Throw_Exception()
        {
            var prgType = typeof(Program);
            var main = prgType.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static);

            main.Invoke(null, new object []{ null });
        }
    }
}
