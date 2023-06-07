using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public class DistritoRepository : IDistrito
    {
        private VentasC conexion = new VentasC();   
        public void add(TbDistrito obj)
        {
            conexion.TbDistritos.Add(obj);  
            conexion.SaveChanges(); 
        }

        public TbDistrito DistritoById(string id)
        {
            throw new NotImplementedException();
        }

        public void editDetails(TbDistrito obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TbDistrito> GetAllDistritos()
        {
            return conexion.TbDistritos;
        }

        public void remove(string id)
        {
            var obj = (from tdis in conexion.TbDistritos
                       where tdis.CodDis == id
                       select tdis).Single();
            conexion.TbDistritos.Remove(obj);
            conexion.SaveChanges();
        }
    }
}
