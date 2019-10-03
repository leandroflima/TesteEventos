using System;

namespace GeradorEvento
{
    public interface IEventos
    {
        event EventHandler<string> TextoRecebido;
    }
}
