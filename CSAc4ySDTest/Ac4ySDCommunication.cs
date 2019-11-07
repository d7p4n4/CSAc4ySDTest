using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4ySDTest
{
    class Ac4ySDCommunication
    {
        [ForeignKey("Message")]
        public int MessageID { get; set; }
        public int Ac4ySDSequenceID { get; set; }
        public Ac4ySDSequence ac4YSDSequence { get; set; }
        public int ID { get; set; }
        public Ac4ySDParticipant Sender { get; set; }
        public Ac4ySDParticipant Receiver { get; set; }
        public Ac4ySDMessage Message { get; set; }
    }
}
