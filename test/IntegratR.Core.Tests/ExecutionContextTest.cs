using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace IntegratR.Core.Tests
{
    public class ExecutionContextTest
    {
        [Fact]
        public void Can_create_new_execution_context()
        {
            var creatorMock = new Mock<IExecutionContext>();
            creatorMock.Setup(m => m.EnsureCreated()).Returns(true);
        }
    }
}
