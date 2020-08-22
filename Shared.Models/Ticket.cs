using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Ticket
    {
        public string UserName { get; set; }
        public DateTime BookedOn { get; set; }
        public string Boarding { get; set; }
        public string Destination { get; set; }
    }
}
