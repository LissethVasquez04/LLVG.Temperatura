using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLVG.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperaturaTest
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            Temperatura calculator = new Temperatura();

            double result = calculator.CelsiusToFahrenheit(0);

            Assert.AreEqual(32, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            Temperatura calculator = new Temperatura();

            double result = calculator.FahrenheitToCelsius(32);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CelsiusToFahrenheitTest_Positive()
        {
            Temperatura calculator = new Temperatura();
            double result = calculator.CelsiusToFahrenheit(100);

            Assert.AreEqual(212, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest_Positive()
        {
            Temperatura calculator = new Temperatura();

            double result = calculator.FahrenheitToCelsius(212);

            Assert.AreEqual(100, result);
        }

        [TestMethod()]
        public void CelsiusToFahrenheitTest_Negative()
        {
            Temperatura calculator = new Temperatura();

            double result = calculator.CelsiusToFahrenheit(-40);

            Assert.AreEqual(-40, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest_Negative()
        {
            Temperatura calculator = new Temperatura();

            double result = calculator.FahrenheitToCelsius(-40);

            Assert.AreEqual(-40, result);
        }
    }
}
