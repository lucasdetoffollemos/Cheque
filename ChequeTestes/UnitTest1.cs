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
            string valor = "2";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.unidades(valor), "DOIS");
        }

        [TestMethod]
        public void DeveMostrarDecimaisReal()
        {
            string valor = "31";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.decimais(valor), "TRINTA E UM");
        }

        [TestMethod]
        public void DeveMostrarCentenas()
        {
            string valor = "802";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.centenas(valor), "OITOSSENTOS E DOIS");
        }

        [TestMethod]
        public void DeveMostrarMilhares()
        {
            string valor = "757912";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.milhares(valor), "SETESSENTOS E CINQUENTA E SETE MIL E NOVESSENTOS E DOZE");
        }

        [TestMethod]
        public void DeveMostrarMilhoes()
        {
            string valor = "200999123";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.milhoes(valor), "DUZENTOS MILHÕES E NOVESSENTOS  E NOVENTA  E NOVE MIL E CENTO E VINTE E TRÊS");
        }

        [TestMethod]
        public void DeveMostrarBilhoes()
        {
            string valor = "23045246018";

            Cheque cheque = new Cheque();

            Assert.AreEqual(cheque.bilhoes(valor), "VINTE E TRÊS BILHÕES E QUARENTA E CINCO MILHÕES E DUZENTOS  E QUARENTA  E SEIS MIL E DEZOITO");
        }
    }
}
