using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public interface IDistrito
    {
        void add(TbDistrito obj);
        IEnumerable<TbDistrito> GetAllDistritos();
        void remove(string id);
        TbDistrito DistritoById(string id);
        void editDetails(TbDistrito obj);
    }
}
