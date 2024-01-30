using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Shipmentinfo
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int date { get; set; }

        public static List<Shipmentinfo> GetAllShipmentinfo()
        {
            return new List<Shipmentinfo> 
            {
                new Shipmentinfo { id = 21, name = "Cargo", date = 2021},
                new Shipmentinfo { id = 19, name = "Newmann", date = 2019},
                new Shipmentinfo { id = 22, name = "Yargo", date = 2022},
                new Shipmentinfo { id = 18, name = "Pewman", date = 2018},
                new Shipmentinfo { id = 16, name = "Cargo", date = 2016},
                new Shipmentinfo { id = 17, name = "Newann", date = 2017},
                new Shipmentinfo { id = 23, name = "Kargo", date = 2023},
                new Shipmentinfo { id = 15, name = "Dewmann", date = 2015}

            };
        }
    }
}
