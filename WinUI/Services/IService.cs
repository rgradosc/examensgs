using System.Threading.Tasks;

namespace ExamenSGS.WinUI.Services
{
    public interface IService<T>
    {
        Task<string> Request(T values);
    }
}
