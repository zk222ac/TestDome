using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public class AlertService
    {
        //private readonly AlertDao _storage = new AlertDao();

        public IAlertDao AlertDao { get; set; }
        public AlertService(IAlertDao iAlertDao)
        {
            AlertDao = iAlertDao;
        }

        public Guid RaiseAlert()
        {
            return AlertDao.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return AlertDao.GetAlert(id);
        }
    }
}
