using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi
{
    public class TransportService : Iinformer
    {
        public TransportService() { }
        public bool addTravelCompany()
        {
            return false;
        }
        public bool deleteTravelCompany()
        {
            return false;
        }
        public List<TravelComp> getTravelCompanies()
        {
            return null;
        }
        public bool sellTicket()
        {
            return false;
        }
        public void inform()
        {
            throw new NotImplementedException();
        }
    }
}
