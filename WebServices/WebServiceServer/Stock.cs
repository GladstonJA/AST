﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceServer
{
    [Serializable]
    public class Stock
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}