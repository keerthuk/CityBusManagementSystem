using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CityBusManagement.Entity.Model
{
    public class RouteDetails
    {
        [Key]
        //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int routeNo { get; set; }
        public string source { get; set; }
        public string destination { get; set; }

    }
}
