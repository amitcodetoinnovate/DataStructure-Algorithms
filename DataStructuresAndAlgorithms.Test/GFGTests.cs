using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.GFG;
using Algorithms.Pramp;
using DataStructures;
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
        public void CountInversion_Test()
        {
            var x = CountInversion.InversionCount(new long[] { 2, 4, 1, 3, 5 }, 5);
            _testOutputHelper.WriteLine(x.Item2);
        }
        [Fact]
        public void NMeetingsInOneRoom_Test()
        {
            NMeetingsInOneRoom.MaxMeetings(new int[] { 1, 3, 0, 5, 8, 5 }, new int[] { 2, 4, 6, 7, 9, 9 }, 6);
        }
        [Fact]
        public void JobSequencingProblem_Test()
        {
         
            JobSequencingProblem.JobScheduling(new Job[] { new Job(1, 4, 20), new Job(2,1,10), new Job(3, 1, 40), new Job(4, 1, 30) }, 4);
        }
        
        [Fact]
        public void FractionalKnapsack_Test()
        {
            
            FractionalKnapsack.KnapSack(50,new Item[] { new Item(60,  10), new Item(100, 20), new Item(120, 30)}, 3);
        }

        [Fact]
        public void MinimumswapsandKtogether_Test()
        {

            MinimumswapsandKtogether.minSwap(new int[]{ 4, 16, 3, 8, 13, 2, 19, 4, 12, 2, 7, 17, 4, 19, 1 }, 15, 9);
        }
    }
}
