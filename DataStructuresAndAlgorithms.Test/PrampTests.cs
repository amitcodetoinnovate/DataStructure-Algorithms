using CodingProblems.Pramp;
using Xunit;

namespace DataStructuresAndAlgorithms.Test
{
    public class PrampTests
    {
        [Fact]
        public void ShiftedArraySearch_Test()
        {
            ShiftedArraySearch.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
        }
    }
}
