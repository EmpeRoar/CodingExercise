
using System;
using Xunit;

namespace MedianOfArrayTest
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, 3)]
        [InlineData(new int[] { 1, 2, 3,4,5 }, new int[] { 6, 7, 8 }, 4.5)]
        public void TestTheMedian(int[] r1, int[] r2, decimal expectedResult)
        {
            // act
            var result = MedainOfArray.Program.GetMedian(r1, r2);

            // assert
            Assert.Equal(expectedResult, result);
        }
    }
}
