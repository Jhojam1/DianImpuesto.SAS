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
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == "Enero")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Febrero")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Marzo")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Abril")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Mayo")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Junio")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                }
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
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == "Julio")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Agosto")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Septiembre")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Octubre")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Noviembre")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                    if (cadena[i] == "Diciembre")
                    {
                        String[] factu = linea.Split(';');
                        facturaPagada(factu);
                    }
                }
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
    }
}  


