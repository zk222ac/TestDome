using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface IAlertDao
    {
        Guid AddAlert(DateTime time);
        DateTime GetAlert(Guid id);

    }
}
