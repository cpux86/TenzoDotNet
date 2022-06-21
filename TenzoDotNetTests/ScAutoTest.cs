using System;
using Xunit;
using TenzoDotNet;

namespace TenzoDotNetTests
{
    public class ScAutoTest
    {
        [Theory]
        [InlineData(1,1)]
        public void GetGetWeight(short port, short address)
        {
            var w = new ScAuto().GetWeight(port, address); 
        }
    }
}
