using OOPProject;
namespace ProjectTest
{
    [TestClass]
    public class ProjectTest
    {
        //Test set of length
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            SnowBoards s = new SnowBoards();
            double expected = 120.0;

            //Act
            s.Length = 100.0;

            //Assert
            Assert.AreEqual(expected, s.Length, 0, "Not Correct");
        }
        //Test set of length
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            SnowBoards s = new SnowBoards();
            double expected = 125.0;

            //Act
            s.Length = 125.0;

            //Assert
            Assert.AreEqual(expected, s.Length, 0, "Not Correct");
        }
        //Test set of length
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            SnowBoards s = new SnowBoards();
            double expected = 120.0;

            //Act
            s.Length = 120.0;

            //Assert
            Assert.AreEqual(expected, s.Length, 0, "Not Correct");
        }
        //Test calculatecost method, with sale
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            SnowBoards s = new SnowBoards();
            decimal expected = 86.25m;

            //Act
            s.Price = 100.0m;
            s.OnSale = true;
            decimal actual = s.CalculateCost();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Not Correct");
        }
        //Test calculatecost method, without sale
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            SnowBoards s = new SnowBoards();
            decimal expected = 115m;

            //Act
            s.Price = 100.0m;
            s.OnSale = false;
            decimal actual = s.CalculateCost();

            //Assert
            Assert.AreEqual(expected, actual, 0, "Not Correct");
        }
    }
}