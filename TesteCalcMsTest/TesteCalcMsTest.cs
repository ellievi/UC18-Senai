using UC18Senai;

namespace TesteCalcMsTest
{
    [TestClass]
    public class TesteCalcMsTest
    {
        [TestMethod]
        public void TesteSomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            var resultado = Calculadora.Somar(pNum, sNum);
            
            Assert.AreEqual(rNum, resultado);
        }
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(1, 2, 3)]
        [DataRow(1, 2, 3)]

        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            var resultado = Calculadora.Somar(pNum, sNum);

            Assert.AreEqual(rNum, resultado);
        }
    }
}