using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public class TemporalVentaRepository : ITemporalVenta
    {
        private List<TemporalVenta> _lst = new List<TemporalVenta>();
        public void add(TemporalVenta temporal)
        {
            _lst.Add(temporal);
        }

        public IEnumerable<TemporalVenta> GetAllTemporarySales()
        {
            return _lst;
        }
    }
}
