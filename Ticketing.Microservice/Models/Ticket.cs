using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketing.Microservice.Models
{
public class Ticket
{
    public string UserName { get; set; }
    public DateTime BookedOn { get; set; } = DateTime.Now;
    public string Boarding { get; set; }
    public string Destination { get; set; }
}
}
