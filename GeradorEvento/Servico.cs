using System;
using System.Threading.Tasks;

namespace GeradorEvento
{
    public class Servico : IServico, IEventos
    {
        public Servico()
        {
        }

        public event EventHandler<string> TextoRecebido;

        public Task GerarEvento(string texto)
        {
            TextoRecebido?.Invoke(this, texto);
            return Task.CompletedTask;
        }
    }
}
