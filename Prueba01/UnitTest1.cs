using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cocinillas;

namespace Prueba01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Definicion de datos. Arrange
            int cantidad = 20;
            int calorias = 150;
            int resultado;

            //Ejecución de la funcionalidad. Action
            resultado = Calorias.calculaCalorias(calorias, cantidad);


            //Comprobación de Resultado. Assert
            Assert.AreEqual(resultado, 3000, "Calculo de calorias incorrecto.");


        }

        [TestMethod]
        public void TestMethod2()
        {
            //Definicion de datos. Arrange
            int cantidad = 50;
            int calorias = 100;
            int resultado;

            //Ejecución de la funcionalidad. Action
            resultado = Calorias.calculaCalorias(calorias, cantidad);


            //Comprobación de Resultado. Assert
            Assert.AreEqual(resultado, 5000, "Calculo de calorias incorrecto.");


        }
    }
}
