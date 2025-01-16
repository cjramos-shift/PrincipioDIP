using System;

namespace CursoFoop_Solid_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logArquivo = new FileLogger();
            ILogger logConsole = new ConsoleLogger();

            Pedido pedidoArquivo = new Pedido(logArquivo);
            pedidoArquivo.AdicionarPedido();

            Pedido pedidoConsole = new Pedido(logConsole);
            pedidoConsole.AdicionarPedido();

            Console.ReadLine();
        }
    }
}
