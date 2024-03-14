using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa.Logica
{
    public class Control
    {

        private int totalPagadas;
        private int totalNoPagadas;

        public int TotalPagadas { get => totalPagadas; set => totalPagadas = value; }
        public int TotalNoPagadas { get => totalNoPagadas; set => totalNoPagadas = value; }

        public void FacturaEnero()
        {
            String FilePatch = @"D:\Ejercicio\Laboratorio.txt";
            StreamReader sr = new StreamReader(FilePatch);
            String linea;
            string[] cadena;
            while ((linea = sr.ReadLine()) != null)
            {
                cadena = linea.Split(';');
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == "Enero")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "SI")
                    {
                        totalPagadas++;
                    }
                    if (cadena[i] == "NO")
                    {
                        totalNoPagadas++;
                    }
                }
            }
            sr.Close();
        }

        public void facturasPrimerSemestre()
        {
            String FilePatch = @"D:\Ejercicio\Laboratorio.txt";
            StreamReader sr = new StreamReader(FilePatch);
            String linea;
            string[] cadena;
            Console.WriteLine("Facturas Del Primer Semestre Pagadas");
            Console.WriteLine();
            while ((linea = sr.ReadLine()) != null)
            {
                cadena = linea.Split(';');
                facturasPorSemestre(cadena, linea, "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio");

            }
            sr.Close();
        }

        public void facturasSegundoSemestre()
        {
            String FilePatch = @"D:\Ejercicio\Laboratorio.txt";
            StreamReader sr = new StreamReader(FilePatch);
            String linea;
            string[] cadena;
            Console.WriteLine("Facturas Del Segundo Semestre Pagadas");
            Console.WriteLine();
            while ((linea = sr.ReadLine()) != null)
            {
                cadena = linea.Split(';');
                facturasPorSemestre(cadena,linea,"Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre");
            }
            sr.Close();
        }

        public void facturaPagada(String[] factura)
        {
            for (int i2 = 0; i2 < factura.Length; i2++)
            {
                if (factura[i2] == "SI")
                {
                    Console.WriteLine("|| Numero De Factura: " + factura[0] + "|| Total De Factura: " 
                        + factura[3] + "|| Mes De La Factura: " + factura[4]+"||");


                }
            }
        }


        public void facturasPorSemestre(String[] cadena,String linea,String mes1,String mes2,String mes3,String mes4,String mes5,String mes6)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == mes1)
                {
                    String[] factu = linea.Split(';');
                    facturaPagada(factu);
                }
                if (cadena[i] == mes2)
                {
                    String[] factu = linea.Split(';');
                    facturaPagada(factu);
                }
                if (cadena[i] == mes3)
                {
                    String[] factu = linea.Split(';');
                    facturaPagada(factu);
                }
                if (cadena[i] == mes4)
                {
                    String[] factu = linea.Split(';');
                    facturaPagada(factu);
                }
                if (cadena[i] == mes5)
                {
                    String[] factu = linea.Split(';');
                    facturaPagada(factu);
                }
                if (cadena[i] == mes6)
                {
                    String[] factu = linea.Split(';');
                    facturaPagada(factu);
                }
            }
        }
    }
}  


