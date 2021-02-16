using System.Threading.Tasks;

namespace ExamenSGS.Application.Interfaces
{
    public interface IRequestHandler<T>
    {
        Task<string> Handler(T request);
    }
}
