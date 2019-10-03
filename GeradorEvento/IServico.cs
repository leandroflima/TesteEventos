using System.Threading.Tasks;

namespace GeradorEvento
{
    public interface IServico
    {
        Task GerarEvento(string texto);
    }
}
