using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MyCalcLib.Tests
{



    [TestClass]

    public class BetanitClassExample
    {
        [TestMethod]

        public void Test2()
        {
            var five = 5;
            var three = 3;
            var eight = five + three;

            Assert.AreEqual(8, eight, "must be 8");
        }

        [TestMethod]
        public void Test()
        {
            //arrange
            int z = 10;
            int v = 20;
            int expected = 30;

            //act
            MyCalc l = new MyCalc();
            int actual = l.Sum(z, v);

            //assert
            Assert.AreEqual(expected, actual);
        }

       /* public void Test_ForbiddenForPackageChunkWhenPackageNotFound()
        {
            //arrange
            
            var packagesRepositoryMock = _mocks.Create<IPackagesRepository>();
            packagesRepositoryMock
                .Setup(r => r.FindPackageAsync(_packageId))
                .Returns(Task<DatabasePackage>.Factory.StartNew(() => null));
            Register(packagesRepositoryMock.Object);

            //act
            var message = PostChunkToServer(new byte[] { 1, 2, 3 });

            //assert
            _mocks.VerifyAll();

            Assert.That(message.StatusCode, Is.EqualTo(HttpStatusCode.Forbidden));
        }
        */
    }
}
