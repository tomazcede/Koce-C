﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koce
{
    public class kraj
    {
        public int id { get; set; }

        public string ime { get; set; }

        public string posta { get; set; }
    }

    public class gore
    {
        public int id { get; set; }

        public string ime { get; set; }

        public string opis { get; set; }
        public int kraj_id { get; set; }
    }

    public class koce
    {
        public int id { get; set; }

        public string ime { get; set; }

        public string opis { get; set; }

        public int nadmorska_visina { get; set; }

        public int gora_id { get; set; }
    }
}