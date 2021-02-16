using System.Threading.Tasks;

namespace ExamenSGS.Application.Interfaces
{
    public interface IQuery<T>
    {
        Task<string> Calculate(T futureYear);
    }
}
