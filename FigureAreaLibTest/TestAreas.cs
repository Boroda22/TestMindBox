using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaLib;
using System;

namespace FigureAreaLibTest
{
    [TestClass]
    public class TestAreas
    {
        [TestMethod]
        public void ItShouldBeCalcAreaCircle()
        {
            double[] values = { 5 };

            var sut = FigureArea.GetArea(values);

            Assert.AreEqual(sut, 78.5);
        }

        [TestMethod]
        public void ItShouldBeCalcAreaTriangle()
        {
            double[] values = { 3, 4, 5 };

            var sut = FigureArea.GetArea(values);

            Assert.AreEqual(sut, 6);
        }

        [TestMethod]
        public void ItShouldBeThrowException()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                double[] values = { 9, 3, 8, 9};
                var sut = FigureArea.GetArea(values);
            });
        }
    }
}
