using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockWriter = new Mock<ITextWriter>();
            var prg = new Program(mockWriter.Object);
            
            prg.SayHello();
            
            mockWriter.Verify(m => m.WriteLine(It.IsAny<string>()), Times.Once);
        }
    }
}
