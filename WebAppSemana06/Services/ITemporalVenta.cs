using WebAppSemana06.Models;

namespace WebAppSemana06.Services
{
    public interface ITemporalVenta
    {
        void add(TemporalVenta temporal);
        IEnumerable<TemporalVenta> GetAllTemporarySales();    
    }
}
