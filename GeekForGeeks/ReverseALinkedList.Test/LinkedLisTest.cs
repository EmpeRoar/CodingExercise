using ReverseALinkedList.App;
using System.Collections.Generic;
using Xunit;

namespace ReverseALinkedList.Test
{
    public class LinkedLisTest
    {
        [Fact]
        public void ReversingLinkedListTest()
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6 };
            var expected = new int[] { 6, 5, 4, 3, 2, 1 };

            var linkedList = App.Program.GenerateLinkedList(data);
            Assert.Equal(1, linkedList.Val);

            var reversedLinkedList = App.Program.ReversedTheLinkedList(linkedList);
            ReverseListValues = new List<int>();
            GetNodeValue(reversedLinkedList);

            Assert.Equal(expected, ReverseListValues.ToArray());
        }

        private List<int> ReverseListValues { get; set; }

        private void GetNodeValue(Node node)
        {
            ReverseListValues.Add(node.Val);
            if (node.Right != null)
            {
                GetNodeValue(node.Right);
            }
        }
    }
}