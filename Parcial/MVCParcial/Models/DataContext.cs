using System.Data.Entity;

namespace MVCParcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base ("DefaultConnection")
        {

        }
    }
}