using System;
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
    }
}
