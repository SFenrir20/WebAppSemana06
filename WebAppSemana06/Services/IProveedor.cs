using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public interface IProveedor
    {
        IEnumerable<TbProveedor> Proveedors();

        TbProveedor GettProveedor(string id);

    }
}
