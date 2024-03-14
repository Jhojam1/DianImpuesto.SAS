using Programa.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Control control = new Control();

        Console.Write("Facturas Del Mes De Enero");
        Console.WriteLine();
        Console.WriteLine();

        control.FacturaEnero();
        Console.WriteLine();

        Console.WriteLine("Total De Facturas Pagadas");
        Console.WriteLine(control.TotalPagadas);
        Console.WriteLine();

        Console.WriteLine("Total De Facturas No Pagadas");
        Console.WriteLine(control.TotalNoPagadas);
        Console.WriteLine();

        control.facturasPrimerSemestre();
        Console.WriteLine();

        control.facturasSegundoSemestre();
        Console.WriteLine();
    }
}