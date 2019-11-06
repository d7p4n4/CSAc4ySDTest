using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4ySDTest
{
    class Ac4ySDMessage
    {

        public int ID { get; set; }
        public string Message { get; set; }
        public string MessageFromSenderAspect { get; set; }
        public string MessageFromReceiverSenderAspect { get; set; }
    }
}
