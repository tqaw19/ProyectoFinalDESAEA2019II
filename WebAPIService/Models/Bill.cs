using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIService.Models
{
    public class Bill
    {
        public int BillID { get; set; }

        public DateTime Date { get; set; }

        public int MyProperty { get; set; }

        //Realizar referencias a las demás entidades.
    }
}