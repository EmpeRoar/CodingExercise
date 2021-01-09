using System;
using Xunit;

namespace ReverseALinkedList.Test
{
    public class LinkedLisTest
    {
        [Fact]
        public void ReversingLinkedListTest()
        {
            var linkedList = App.Program.GenerateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.Equal(1, linkedList.Val);

            var reversedLinkedList = App.Program.ReversedTheLinkedList(linkedList);
            Assert.Equal(6, reversedLinkedList.Val);
        }
    }
}
