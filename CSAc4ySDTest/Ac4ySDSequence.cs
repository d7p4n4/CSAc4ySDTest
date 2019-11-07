using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4ySDTest
{
    class Ac4ySDSequence
    {
        public int ID { get; set; }
        [Column("Communications")]
        public ICollection<Ac4ySDCommunication> Communications { get; set; }

    }
}
