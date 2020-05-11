using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class User:IColleague
    {
        public User(IMediator mediator) : base(mediator)
        {

        }

        public override void Receive(string message)
        {
            Console.WriteLine("Un usuario recibe: " + message);
        }
    }
}
