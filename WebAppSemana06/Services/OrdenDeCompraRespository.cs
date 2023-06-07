using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public class OrdenDeCompraRespository : IOrdenDeCompra
    {
        private VentasC Cconexion = new VentasC();
        public IEnumerable<TbOrdenCompra> GetAll()
        {
            return Cconexion.TbOrdenCompras;
        }

        public TbOrdenCompra GetOrdenCompra(string id)
        {
            return (from AlOrden in Cconexion.TbOrdenCompras
                    where AlOrden.NumOco == id
                    select AlOrden).Single();
        }
    }
}
