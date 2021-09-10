using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.GFG;
using Xunit;
using Xunit.Abstractions;

namespace DataStructuresAndAlgorithms.Test
{
    public class GFGTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public GFGTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void SetMatrixZeroes_Test()
        {
            var x = CountInversion.InversionCount(new long[] { 2, 4, 1, 3, 5 }, 5);
            _testOutputHelper.WriteLine(x.Item2);
        }
    }
}
