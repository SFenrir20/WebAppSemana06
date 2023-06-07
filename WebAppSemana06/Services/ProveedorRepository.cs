using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public class ProveedorRepository : IProveedor
    {
        private VentasC Cconexion = new VentasC();

        public TbProveedor GettProveedor(string id)
        {
            return (from proveedor in Cconexion.TbProveedors
                    where proveedor.CodPrv == id
                    select proveedor).Single();
        }

        public IEnumerable<TbProveedor> Proveedors()
        {
            return Cconexion.TbProveedors;
        }
    }
}
