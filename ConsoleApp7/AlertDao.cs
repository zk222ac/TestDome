using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   
        public class AlertDao : IAlertDao
        {
            private readonly Dictionary<Guid, DateTime> _alerts = new Dictionary<Guid, DateTime>();

            public Guid AddAlert(DateTime time)
            {
                Guid id = Guid.NewGuid();
                _alerts.Add(id, time);
                return id;
            }

            public DateTime GetAlert(Guid id)
            {
                return _alerts[id];
            }
        }
    
}
