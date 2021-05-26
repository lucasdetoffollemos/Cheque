using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheques.ConsoleApp
{
    public class Cheque
    {
        public string Valor { get; private set; }

 

        public String unidades(String valorStr)
        {
            int valor = Convert.ToInt32(valorStr);
            String nome = "";
            switch (valor)
            {
                case 1:
                    nome = "UM";
                    break;
                case 2:
                    nome = "DOIS";
                    break;
                case 3:
                    nome = "TRÊS";
                    break;
                case 4:
                    nome = "QUATRO";
                    break;
                case 5:
                    nome = "CINCO";
                    break;
                case 6:
                    nome = "SEIS";
                    break;
                case 7:
                    nome = "SETE";
                    break;
                case 8:
                    nome = "OITO";
                    break;
                case 9:
                    nome = "NOVE";
                    break;
            }
            return nome;
        }

        public String decimais(String valorStr)
        {
            int valor = Convert.ToInt32(valorStr);
            String nome = null;
            switch (valor)
            {
                case 10:
                    nome = "DEZ";
                    break;
                case 11:
                    nome = "ONZE";
                    break;
                case 12:
                    nome = "DOZE";
                    break;
                case 13:
                    nome = "TREZE";
                    break;
                case 14:
                    nome = "QUATORZE";
                    break;
                case 15:
                    nome = "QUINZE";
                    break;
                case 16:
                    nome = "DEZESSEIS";
                    break;
                case 17:
                    nome = "DEZESSETE";
                    break;
                case 18:
                    nome = "DEZOITO";
                    break;
                case 19:
                    nome = "DEZENOVE";
                    break;
                case 20:
                    nome = "VINTE";
                    break;
                case 30:
                    nome = "TRINTA";
                    break;
                case 40:
                    nome = "QUARENTA";
                    break;
                case 50:
                    nome = "CINQUENTA";
                    break;
                case 60:
                    nome = "SESSENTA";
                    break;
                case 70:
                    nome = "SETENTA";
                    break;
                case 80:
                    nome = "OITENTA";
                    break;
                case 90:
                    nome = "NOVENTA";
                    break;
                default:
                    if (valor > 0)
                    {
                        nome = decimais(valorStr.Substring(0, 1) + "0") + " E " + unidades(valorStr.Substring(1));
                    }

                    break;
            }

            return nome;
        }

        public String centenas(String valorStr)
        {
            int valor = Convert.ToInt32(valorStr);
            String nome = null;

            if(valor == 100)
            {
                nome = "CEM";
            }
            else if (valor == 200)
            {
                nome = "DUZENTOS";
            }
            else if (valor == 300)
            {
                nome = "TREZENTOS";
            }
            else if (valor == 400)
            {
                nome = "QUATROCENTOS";
            }
            else if (valor == 500)
            {
                nome = "QUINHENTOS";
            }
            else if (valor == 600)
            {
                nome = "SEISSENTOS";
            }
            else if (valor == 700)
            {
                nome = "SETESSENTOS";
            }
            else if (valor == 800)
            {
                nome = "OITOSSENTOS";
            }
            else if (valor == 900)
            {
                nome = "NOVESSENTOS";
            }
            else
            {
                if (valor > 0)
                {
                    nome = centenas(valorStr.Substring(0, 1) + "0" + "0");
                    if (nome == "CEM" && (valorStr.Substring(1,1) != "0"|| valorStr.Substring(2, 1) != "0")){
                        nome = "CENTO";
                    }

                    if (valorStr.Substring(1,1) != "0" )
                    {
                        if(valorStr.Substring(1, 1) != "1")
                            nome += " E " + decimais(valorStr.Substring(1,2) + "0");
                        else
                            nome += " E " + decimais(valorStr.Substring(1, 2));
                    }

                    if(valorStr.Substring(2,1) != "0" && valorStr.Substring(1, 1) != "1")
                    {
                        if(valorStr.Substring(1, 1) != "0")
                        {
                            nome += unidades(valorStr.Substring(2));
                        }
                        else
                        {
                            nome += " E " + unidades(valorStr.Substring(2));
                        } 
                    }  
                }
            }
            return nome;
        }


        public String milhares(String valorStr)
        {
            int valor = Convert.ToInt32(valorStr);
            String nome = null;

            if (valorStr.Length == 4)
            {
                if(valorStr.Substring(0, 1) != "1")
                {
                    nome = unidades(valorStr.Substring(0, 1)) + " MIL";
                }
                else
                {
                    nome = "MIL";
                }
                

                if (valorStr.Substring(1, 1) != "0") { 

                    nome += " " + centenas(valorStr.Substring(1, 1) + "0" + "0");

                    if (valorStr.Substring(1, 1) == "1" && (valorStr.Substring(2, 1) != "0" || valorStr.Substring(3, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }

                    
                }

                if (valorStr.Substring(2, 1) != "0")
                {
                   
                    nome += " E " + decimais(valorStr.Substring(2, 2));
                }

                if (valorStr.Substring(3, 1) != "0" && valorStr.Substring(2, 1) != "1")
                {
                    if (valorStr.Substring(2, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(3));
                    }
                   
                }
            }

            if (valorStr.Length == 5)
            {
            
                nome = decimais(valorStr.Substring(0, 2)) + " MIL";

                if (valorStr.Substring(2, 1) != "0")
                {
                    
                    nome += " E " + centenas(valorStr.Substring(2, 1) + "0" + "0");

                    if (valorStr.Substring(2, 1) == "1" && (valorStr.Substring(3, 1) != "0" || valorStr.Substring(4, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(3, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(3, 2));
                }

                if (valorStr.Substring(4, 1) != "0" && valorStr.Substring(3, 1) != "1")
                {
                    if (valorStr.Substring(3, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(4));
                    }

                }
            }

            if (valorStr.Length == 6)
            {

                nome = centenas(valorStr.Substring(0, 3)) + " MIL";

                if (valorStr.Substring(3, 1) != "0")
                {

                    nome += " E " + centenas(valorStr.Substring(3, 1) + "0" + "0");

                    if (valorStr.Substring(3, 1) == "1" && (valorStr.Substring(4, 1) != "0" || valorStr.Substring(5, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(4, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(4, 2));
                }

                if (valorStr.Substring(5, 1) != "0" && valorStr.Substring(4, 1) != "1")
                {
                    if (valorStr.Substring(4, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(5));
                    }

                }
            }
            return nome;
        }

        public String milhoes(String valorStr)
        {
            int valor = Convert.ToInt32(valorStr);
            String nome = null;

            if (valorStr.Length == 7)
            {
                nome = unidades(valorStr.Substring(0, 1));

                if (valorStr.Substring(0, 1) != "1")
                {
                    nome += " MILHÕES";
                }
                else
                {
                    nome +=  " MILHÃO";
                }

                if (valorStr.Substring(1, 1) != "0")
                {
                    nome += " E " + milhares(valorStr.Substring(1, 1) +"0"+"0"+"0"+"0"+"0");
                }

                if (valorStr.Substring(2, 1) != "0") {

                    if(valorStr.Substring(1,1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }
                    
                    nome += " E " + milhares(valorStr.Substring(2, 1) + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(3, 1) != "0")
                {
                    if (valorStr.Substring(1, 1) != "0" || valorStr.Substring(2, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(3, 1) + "0" + "0" + "0");
                }

                if (valorStr.Substring(4, 1) != "0")
                {
                    nome += " E " + centenas(valorStr.Substring(4, 1) + "0" + "0");

                    if (valorStr.Substring(4, 1) == "1" && (valorStr.Substring(5, 1) != "0" || valorStr.Substring(6, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(5, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(5, 2));
                }

                if (valorStr.Substring(6, 1) != "0" && valorStr.Substring(5, 1) != "1")
                {
                    if (valorStr.Substring(5, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(6));
                    }

                }
            }

            if (valorStr.Length == 8)
            {
                nome = decimais(valorStr.Substring(0, 2)) + " MILHÕES";

                if (valorStr.Substring(2, 1) != "0")
                {
                    nome += " E " + milhares(valorStr.Substring(2, 1) + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(3, 1) != "0")
                {

                    if (valorStr.Substring(2, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(3, 1) + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(4, 1) != "0")
                {
                    if (valorStr.Substring(2, 1) != "0" || valorStr.Substring(3, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(4, 1) + "0" + "0" + "0");
                }

                if (valorStr.Substring(5, 1) != "0")
                {
                    nome += " E " + centenas(valorStr.Substring(5, 1) + "0" + "0");

                    if (valorStr.Substring(5, 1) == "1" && (valorStr.Substring(6, 1) != "0" || valorStr.Substring(7, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(6, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(6, 2));
                }

                if (valorStr.Substring(6, 1) != "0" && valorStr.Substring(6, 1) != "1")
                {
                    if (valorStr.Substring(6, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(7));
                    }
                }
            }

            if (valorStr.Length == 9)
            {
                nome = centenas(valorStr.Substring(0, 3)) + " MILHÕES";

                if (valorStr.Substring(3, 1) != "0")
                {
                    nome += " E " + milhares(valorStr.Substring(3, 1) + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(4, 1) != "0")
                {

                    if (valorStr.Substring(3, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(4, 1) + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(5, 1) != "0")
                {
                    if (valorStr.Substring(3, 1) != "0" || valorStr.Substring(4, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(5, 1) + "0" + "0" + "0");
                }

                if (valorStr.Substring(6, 1) != "0")
                {
                    nome += " E " + centenas(valorStr.Substring(6, 1) + "0" + "0");

                    if (valorStr.Substring(6, 1) == "1" && (valorStr.Substring(7, 1) != "0" || valorStr.Substring(8, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(7, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(7, 2));
                }

                if (valorStr.Substring(7, 1) != "0" && valorStr.Substring(7, 1) != "1")
                {
                    if (valorStr.Substring(7, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(8));
                    }
                }
            }

            return nome;
        }

        public String bilhoes(String valorStr)
        {
            long valor = Convert.ToInt64(valorStr);
            String nome = null;

            if (valorStr.Length == 10)
            {
                nome = unidades(valorStr.Substring(0, 1));

                if (valorStr.Substring(0, 1) != "1")
                {
                    nome += " BILHÕES";
                }
                else
                {
                    nome += " BILHÃO";
                }

                if (valorStr.Substring(1, 1) != "0")
                {
                    // 9 9 0 0 0 0 0 0 0
                    nome += " E " + milhoes(valorStr.Substring(1, 3) + "0" + "0" + "0" + "0" +"0"+ "0");
                }

                if (valorStr.Substring(2, 1) != "0" && valorStr.Substring(1, 1) == "0")
                {

                    //if (valorStr.Substring(1, 1) != "0")
                    //{
                    //    int pos = nome.LastIndexOf("MILHÃO");
                    //    nome = nome.Remove(pos, 5);
                    //}
                    nome += " E " + milhoes(valorStr.Substring(2, 2) + "0" + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(3, 1) != "0" && valorStr.Substring(1, 1) == "0" && valorStr.Substring(2, 1) == "0")
                {
                    //if (valorStr.Substring(1, 1) != "0" || valorStr.Substring(2, 1) != "0")
                    //{

                    //    int pos = nome.LastIndexOf("MILHÃO");
                    //    nome = nome.Remove(pos, 5);
                    //}

                    nome += " E " + milhoes(valorStr.Substring(3, 1) + "0" + "0" + "0" + "0" + "0" + "0");
                }


                if (valorStr.Substring(4, 1) != "0")
                {
                    nome += " E " + milhares(valorStr.Substring(4, 1) + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(5, 1) != "0")
                {

                    if (valorStr.Substring(4, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(5, 1) + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(6, 1) != "0")
                {
                    if (valorStr.Substring(4, 1) != "0" || valorStr.Substring(5, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }
                    nome += " E " + milhares(valorStr.Substring(6, 1) + "0" + "0" + "0");
                }

                if (valorStr.Substring(7, 1) != "0")
                {
                    nome += " E " + centenas(valorStr.Substring(7, 1) + "0" + "0");

                    if (valorStr.Substring(7, 1) == "1" && (valorStr.Substring(8, 1) != "0" || valorStr.Substring(9, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(8, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(8, 2));
                }

                if (valorStr.Substring(9, 1) != "0" && valorStr.Substring(8, 1) != "1")
                {
                    if (valorStr.Substring(8, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(9));
                    }
                }
            }

            if (valorStr.Length == 11)
            {
                nome = decimais(valorStr.Substring(0, 2));

               
                nome += " BILHÕES";

                

                if (valorStr.Substring(2, 1) != "0")
                {
                    // 9 9 0 0 0 0 0 0 0
                    nome += " E " + milhoes(valorStr.Substring(2, 3) + "0" + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(3, 1) != "0" && valorStr.Substring(2, 1) == "0")
                {

                    //if (valorStr.Substring(1, 1) != "0")
                    //{
                    //    int pos = nome.LastIndexOf("MILHÃO");
                    //    nome = nome.Remove(pos, 5);
                    //}
                    nome += " E " + milhoes(valorStr.Substring(3, 2) + "0" + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(4, 1) != "0" && valorStr.Substring(2, 1) == "0" && valorStr.Substring(3, 1) == "0")
                {
                    //if (valorStr.Substring(1, 1) != "0" || valorStr.Substring(2, 1) != "0")
                    //{

                    //    int pos = nome.LastIndexOf("MILHÃO");
                    //    nome = nome.Remove(pos, 5);
                    //}

                    nome += " E " + milhoes(valorStr.Substring(4, 1) + "0" + "0" + "0" + "0" + "0" + "0");
                }


                if (valorStr.Substring(5, 1) != "0")
                {
                    nome += " E " + milhares(valorStr.Substring(5, 1) + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(6, 1) != "0")
                {

                    if (valorStr.Substring(5, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(6, 1) + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(7, 1) != "0")
                {
                    if (valorStr.Substring(5, 1) != "0" || valorStr.Substring(6, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }
                    nome += " E " + milhares(valorStr.Substring(7, 1) + "0" + "0" + "0");
                }

                if (valorStr.Substring(8, 1) != "0")
                {
                    nome += " E " + centenas(valorStr.Substring(8, 1) + "0" + "0");

                    if (valorStr.Substring(8, 1) == "1" && (valorStr.Substring(9, 1) != "0" || valorStr.Substring(10, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(9, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(9, 2));
                }

                if (valorStr.Substring(9, 1) != "0" && valorStr.Substring(9, 1) != "1")
                {
                    if (valorStr.Substring(9, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(10));
                    }
                }
            }

            if (valorStr.Length == 12)
            {
                nome = centenas(valorStr.Substring(0, 3));


                nome += " BILHÕES";

                if (valorStr.Substring(3, 1) != "0")
                {
                    // 9 9 0 0 0 0 0 0 0
                    nome += " E " + milhoes(valorStr.Substring(3, 3) + "0" + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(4, 1) != "0" && valorStr.Substring(3, 1) == "0")
                {

                    
                    nome += " E " + milhoes(valorStr.Substring(4, 2) + "0" + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(5, 1) != "0" && valorStr.Substring(3, 1) == "0" && valorStr.Substring(4, 1) == "0")
                {
                
                    nome += " E " + milhoes(valorStr.Substring(5, 1) + "0" + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(6, 1) != "0")
                {
                    nome += " E " + milhares(valorStr.Substring(6, 1) + "0" + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(7, 1) != "0")
                {

                    if (valorStr.Substring(6, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }

                    nome += " E " + milhares(valorStr.Substring(7, 1) + "0" + "0" + "0" + "0");
                }

                if (valorStr.Substring(8, 1) != "0")
                {
                    if (valorStr.Substring(6, 1) != "0" || valorStr.Substring(7, 1) != "0")
                    {
                        int pos = nome.LastIndexOf("MIL");
                        nome = nome.Remove(pos, 3);
                    }
                    nome += " E " + milhares(valorStr.Substring(8, 1) + "0" + "0" + "0");
                }

                if (valorStr.Substring(9, 1) != "0")
                {
                    nome += " E " + centenas(valorStr.Substring(9, 1) + "0" + "0");

                    if (valorStr.Substring(9, 1) == "1" && (valorStr.Substring(10, 1) != "0" || valorStr.Substring(11, 1) != "0"))
                    {
                        int pos = nome.IndexOf("CEM");
                        nome = nome.Remove(pos, 3);
                        nome += "CENTO";
                    }
                }

                if (valorStr.Substring(10, 1) != "0")
                {

                    nome += " E " + decimais(valorStr.Substring(10, 2));
                }

                if (valorStr.Substring(10, 1) != "0" && valorStr.Substring(10, 1) != "1")
                {
                    if (valorStr.Substring(10, 1) == "0")
                    {
                        nome += " E " + unidades(valorStr.Substring(11));
                    }
                }
            }

            return nome;
        }

    }
}
