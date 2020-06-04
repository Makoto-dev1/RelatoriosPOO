
namespace RelatoriosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Relatórios :");
            Relatorio relatorio = new Relatorio();
            System.Console.WriteLine("Digite a data do relatorio:");
            relatorio.data = System.DateTime.Parse( System.Console.ReadLine());
            System.Console.WriteLine("Data: " + relatorio.data);

            Mensal mensal = new Mensal();
            mensal.MostrarRelatorio();

            Anual anual = new Anual();
            anual.MostrarRelatorio();
        }
    }
}
