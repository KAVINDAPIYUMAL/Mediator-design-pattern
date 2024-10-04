using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    public interface IChatMediator
    {
        void SendMessage(User sender, string message);
    }
}
