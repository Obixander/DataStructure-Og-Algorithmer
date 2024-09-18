using CustomDataStructures;

namespace DataStructures.Test
{
    public class StackTesting
    {
        [Fact]
        public void Push()
        {
            //Arrange
            CustomStack<int> stack = new CustomStack<int>();

            //Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //Assert
            Assert.Equal(1, stack.Peek(0));
            Assert.Equal(2, stack.Peek(1));
            Assert.Equal(3, stack.Peek(2));
            Assert.Equal(3, stack.GetLength());
        }

        [Fact]
        public void Pop()
        {
            //Arrange
            CustomStack<int> stack = new CustomStack<int>();


            //Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var test1 = stack.Pop();
            var test2 = stack.Pop();
            var test3 = stack.Pop();

            //Assert
            Assert.Equal(3, test1);
            Assert.Equal(2, test2);
            Assert.Equal(1, test3);
            Assert.Equal(0, stack.GetLength());
        }

        [Fact]
        public void IsPalidrome()
        {
            //Arrange
            CustomStack<string> TestStack = new();
            CustomStack<string> TestStack2 = new();

            TestStack.Push("n");
            TestStack.Push("u");
            TestStack.Push("n");

            TestStack2.Push("m");
            TestStack2.Push("o");
            TestStack2.Push("o");
            TestStack2.Push("n");

            //Act
            var test = TestStack.IsPalindrom();
            var test2 = TestStack2.IsPalindrom();

            //Assert
            Assert.True(test);
            Assert.False(test2);

        }
        [Fact]
        public void PushPopTo()
        {

            //Arrange
            CustomStack<int> stack1 = new();
            CustomStack<int> stack2 = new();

            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            //act       
            stack1.PopPushTo(stack2);

            //Assert
            Assert.Equal(3, stack2.Peek(0));
            Assert.Equal(2, stack1.Peek(1));
            Assert.Equal(1, stack1.Peek(0));



        }


    }
}