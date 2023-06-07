using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public interface IOrdenDeCompra
    {
        IEnumerable<TbOrdenCompra> GetAll();

        TbOrdenCompra GetOrdenCompra(string id);

    }
}
