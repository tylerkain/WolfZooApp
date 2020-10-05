using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WolfWorld.Models
{
    public class ListOfWolves
    {
        public int ID { get; set; }
        public string Subspecies { get; set; }
        public string Description { get; set; }
        public string Range { get; set; }
        public string Order { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string ConservationStatus { get; set; }

    }
}
