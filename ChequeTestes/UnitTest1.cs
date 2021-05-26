using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cheques.ConsoleApp;

namespace ChequeTestes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveMostrarUnidadeReal()
        {
            string valor = "1.10";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.ColocandoOReal(valor), "UM REAL E DEZ CENTAVOS");
        }

        [TestMethod]
        public void DeveMostrarDecimaisReal()
        {
            string valor = "31";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.ColocandoOReal(valor), "TRINTA E UM REAIS");
        }

        [TestMethod]
        public void DeveMostrarCentenas()
        {
            string valor = "802";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.ColocandoOReal(valor), "OITOSSENTOS E DOIS REAIS");
        }

        [TestMethod]
        public void DeveMostrarMilhares()
        {
            string valor = "757912.09";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.ColocandoOReal(valor), "SETESSENTOS E CINQUENTA E SETE MIL E NOVESSENTOS E DOZE REAIS E NOVE CENTAVOS");
        }

        [TestMethod]
        public void DeveMostrarMilhoes()
        {
            string valor = "200999123";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.ColocandoOReal(valor), "DUZENTOS MILHÕES E NOVESSENTOS  E NOVENTA  E NOVE MIL E CENTO E VINTE E TRÊS REAIS");
        }

        [TestMethod]
        public void DeveMostrarBilhoes()
        {
            string valor = "23045246018";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.ColocandoOReal(valor), "VINTE E TRÊS BILHÕES E QUARENTA E CINCO MILHÕES E DUZENTOS  E QUARENTA  E SEIS MIL E DEZOITO REAIS");
        }


        [TestMethod]
        public void NaoDeveMostrarCentavosComTamnhoDiferenteDeDois()
        {

            bool naoConseguiuValidar = false;

            try
            {
                Cheque cheque = new Cheque();
                cheque.ColocandoOReal("230.9");
            }
            catch
            {
                naoConseguiuValidar = true;
            }
            
            Assert.AreEqual(naoConseguiuValidar, true);
        }

        [TestMethod]
        public void NaoDeveMostrarValorMenorQue1()
        {

            bool naoConseguiuValidar = false;

            try
            {
                Cheque cheque = new Cheque();
                cheque.ColocandoOReal("");
            }
            catch
            {
                naoConseguiuValidar = true;
            }

            Assert.AreEqual(naoConseguiuValidar, true);
        }


        [TestMethod]
        public void NaoDeveMostrarValorMaiorQue12()
        {

            bool naoConseguiuValidar = false;

            try
            {
                Cheque cheque = new Cheque();
                cheque.ColocandoOReal("12345678912100");
            }
            catch
            {
                naoConseguiuValidar = true;
            }

            Assert.AreEqual(naoConseguiuValidar, true);
        }

        [TestMethod]
        public void NaoDeveMostrarValorQueContemLetra()
        {

            bool naoConseguiuValidar = false;

            try
            {
                Cheque cheque = new Cheque();
                cheque.ColocandoOReal("123sddfs670");
            }
            catch
            {
                naoConseguiuValidar = true;
            }

            Assert.AreEqual(naoConseguiuValidar, true);
        }



    }
}
