using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4ySDTest
{
    class Ac4ySDCommunication
    {
        public int ID { get; set; }
        public Ac4ySDParticipant Sender { get; set; }
        public Ac4ySDParticipant Receiver { get; set; }
        public Ac4ySDMessage Message { get; set; }
    }
}
