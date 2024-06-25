using Base.App;

namespace Base.Test
{
    public class UnitTest1
    {
        [Fact]
        public void FindSquareTest()
        {
            // call the FindSquare method from the Program class
            double answer = Program.FindSquare(5);
            Assert.Equal(25, answer);
        }

        [Fact]
        public void FindCubeTest()
        {
            // call the FindCube method from the Program class
            double answer = Program.FindCube(5);
            Assert.Equal(125, answer);
        }
    }
}