using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator mediator = new ChatMediator();

            User user1 = new User(mediator, "Alice");
            User user2 = new User(mediator, "Bob");
            User user3 = new User(mediator, "Charlie");

            user1.SendMessage("Hello, everyone!");
        }
    }
}
