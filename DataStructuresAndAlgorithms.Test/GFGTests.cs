using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.GFG;
using Algorithms.Pramp;
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
        [Fact]
        public void NMeetingsInOneRoom_Test()
        {
            NMeetingsInOneRoom.MaxMeetings(new int[] { 1, 3, 0, 5, 8, 5 }, new int[] { 2, 4, 6, 7, 9, 9 }, 6);
        }
    }
}
