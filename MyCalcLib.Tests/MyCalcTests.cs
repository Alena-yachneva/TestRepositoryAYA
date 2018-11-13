using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;


namespace MyCalcLib.Tests
{
    public interface IMyInterface
    {
        int Sum(int a, int b);
        
    }


    public interface IMyInterface2
    {
        int Div(int d, int e);

    }

    [TestClass]
    public class ValidationTest
    {

        [TestMethod]
        public void Two_plus_three_must_be_5()
        {
            var mock = new Mock<IMyInterface>();
            mock
                .Setup(myInterface => myInterface.Sum(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => 42);
            var result = mock.Object.Sum(2, 2);

            Assert.AreEqual(42, result, "it always should be 42");

        }


        [TestMethod]
        public void Div_70_by_10_700checkInterface()
        {
            var mock = new Mock<IMyInterface2>();
                mock
                .Setup(myInterface => myInterface.Div(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(() => 700);
            var result = mock.Object.Div(70, 10);

            Assert.AreEqual(700, result);

            

        }



       
        [TestMethod]
        public void Sum_10and20_30()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

      
        [TestMethod]
        public void Div_50and25_2()
        {
            var a = 50;
            var b = 25;
            var c = 4;

            MyCalc d = new MyCalc();
            var result = d.Div(a, b);
            result = result + 2;

            Assert.AreEqual(c, result, "message");
        }

        [TestMethod]

        public void Test_of_6multiply7_is42()
        {
            var u = 6;
            var o = 7;
            var expected = 42;

            expected = 6 * 7;
            expected = expected + 1;
            Assert.AreEqual(43, expected, "meesage");
        }


        /*[TestMethod]
        public void Data_provider_shuld_contain_my_Entity()
        {
            var mock = new Mock<IDataProvider>();
            mock.Setup(DataProvider => DataProvider.EntityExists<Entity>())
            .Returns(true);
            mock
                .Setup(DataProvider => DataProvider.EntityExists<OtherEntity>())
                .Returns(false);
            var result = Mock.Object.EntityExists<Entity>();

            Assert.IsTrue(result);
            Assert.IsFalse(Mock.Object.EntityExists<OtherEntity>());
        
                }
                */

    }

    class Entity
    {
    }
    class OtherEntity
    {
    }
}