using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public interface IProducto
    {
        IEnumerable<TbProducto> GetAllProducts();
        TbProducto GetProduct(string id);
    }
}
