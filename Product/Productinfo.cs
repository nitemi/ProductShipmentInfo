using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Productinfo
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int date { get; set; }

        public static List<Productinfo> GetAllProductinfo()
        {
            return new List<Productinfo>
            {
                new Productinfo() { id = 01, name = "Wristwatch", date = 2018 },
        new Productinfo() { id = 02, name = "Necklace", date = 2021 },
        new Productinfo() { id = 13, name = "Wristwatch", date = 2018 },
        new Productinfo() { id = 04, name = "Necklace", date = 2023 },
        new Productinfo() { id = 15, name = "Wristwatch", date = 2024 },
        new Productinfo() { id = 16, name = "Necklace", date = 2019 },
        new Productinfo() { id = 15, name = "Wristwatch", date = 2024 },
        new Productinfo() { id = 04, name = "Necklace", date = 2022 },
        new Productinfo() { id = 04, name = "Wristwatch", date = 2023  },
        new Productinfo() { id = 13, name = "Necklace", date = 2019},
        new Productinfo() { id = 11, name = "Wristwatch", date = 2012 },
        new Productinfo() { id = 12, name = "Necklace", date = 2017 },
        new Productinfo() { id = 13, name = "Wristwatch", date = 2012 },
        new Productinfo() { id = 14, name = "Necklace", date = 2016 },
        new Productinfo() { id = 15, name = "Wristwatch", date = 2026 },
        new Productinfo() { id = 16, name = "Necklace", date = 2034 },
        new Productinfo() { id = 10, name = "Wristwatch", date = 2020 },
        new Productinfo() { id = 13, name = "Necklace", date = 2011 },
        new Productinfo() { id = 10, name = "Wristwatch", date = 2020 },
        new Productinfo() { id = 04, name = "Necklace", date = 2022 },
        new Productinfo() { id = 14, name = "Wristwatch", date = 2017 },
        new Productinfo() { id = 14, name = "Necklace", date = 2013 },
        new Productinfo() { id = 13, name = "Wristwatch", date = 2010 },
        new Productinfo() { id = 04, name = "Necklace", date = 2019 },
        new Productinfo() { id = 01, name = "Wristwatch", date = 2017 },
        new Productinfo() { id = 02, name = "Necklace", date = 2015 },
        new Productinfo() { id = 13, name = "Wristwatch", date = 2017 },
        new Productinfo() { id = 04, name = "Necklace", date = 2022 },
        new Productinfo() { id = 15, name = "Wristwatch", date = 2019 },
        new Productinfo() { id = 16, name = "Necklace", date = 2019 },
        new Productinfo() { id = 02, name = "Wristwatch", date = 2017 },
        new Productinfo() { id = 04, name = "Necklace", date = 2022 },
        new Productinfo() { id = 01, name = "Wristwatch", date = 2022 },
        new Productinfo() { id = 10, name = "Necklace", date = 2018 },
        new Productinfo() { id = 15, name = "Wristwatch", date = 2034 },
        new Productinfo() { id = 13, name = "Necklace", date = 2018 },
        new Productinfo() { id = 01, name = "Wristwatch", date = 2034 },
        new Productinfo() { id = 02, name = "Necklace", date = 2018 },
        new Productinfo() { id = 04, name = "Wristwatch", date = 2018 },
        new Productinfo() { id = 04, name = "Necklace", date = 2019 },
        new Productinfo() { id = 15, name = "Wristwatch", date = 2022 },
        new Productinfo() { id = 16, name = "Necklace", date = 2024 },
        new Productinfo() { id = 10, name = "Wristwatch", date = 2017 },
        new Productinfo() { id = 02, name = "Necklace", date = 2024},
        new Productinfo() { id = 04, name = "Wristwatch", date = 2018 },
        new Productinfo() { id = 10, name = "Necklace", date = 2012 },
        new Productinfo() { id = 01, name = "Wristwatch", date = 2010 },
        new Productinfo() { id = 02, name = "Necklace", date = 2018 },

            };
        }

    }
}
