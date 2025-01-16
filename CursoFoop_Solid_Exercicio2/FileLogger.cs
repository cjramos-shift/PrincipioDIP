using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio2
{
    public class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            //código para salvar log em arquivo
            Console.WriteLine("Arquivo salvo com os dados em CSV: " + mensagem);
        }
    }
}
