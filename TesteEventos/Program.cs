using System;

namespace TesteEventos
{
    class Program
    {
        private static GeradorEvento.Servico servico;

        static void Main(string[] args)
        {
            servico = new GeradorEvento.Servico();
            servico.TextoRecebido += Servico_TextoRecebido;

            Console.WriteLine("Inicio'");

            Console.WriteLine("Digite qualquer texto para enviar evento");
            var texto = Console.ReadLine();
            servico.GerarEvento(texto);

            Console.WriteLine("Após GerarEvento");
            Console.Read();
        }

        private static void Servico_TextoRecebido(object sender, string e)
        {
            Console.WriteLine($"Servico_TextoRecebido:{e}");
        }
    }
}
