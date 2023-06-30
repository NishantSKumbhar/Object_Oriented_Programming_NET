using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Interface
{
    public class Order
    {
        public int Id { get; set; }
        public Shipment Shipment;
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped 
        {
            get { return Shipment!= null; }
        }

    }
}
