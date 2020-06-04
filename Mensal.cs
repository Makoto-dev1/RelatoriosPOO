namespace RelatoriosPOO
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            // para aproveitar da classe pai
            // base.MostrarRelatorio();
            // Adicionando novas ações
            System.Console.WriteLine("Mostrando relatório por mês");
        }
    }
}