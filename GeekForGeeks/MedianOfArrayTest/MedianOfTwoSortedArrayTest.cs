
using System;
using Xunit;

namespace MedianOfArrayTest
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5,6,7 }, 4)]
        [InlineData(new int[] { 1, 2, 3,4,5 }, new int[] { 6, 7, 8 }, 4.5)]
        [InlineData(new int[] {  }, new int[] { 1 }, 1 )]
        [InlineData(new int[] { 1,3}, new int[] { 2 }, 2)]
        public void TestTheMedian(int[] r1, int[] r2, double expectedResult)
        {
            // act
            var result = MedainOfArray.Program.GetMedian(r1, r2);

            // assert
            Assert.Equal(expectedResult, result);
        }
    }
}
