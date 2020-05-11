using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IMediator
    {
        void Send(string message, IColleague colleague);
    }
}
