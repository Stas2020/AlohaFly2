﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StoreHouseConnect
{
    public class TItemDocument
    {
        [DataMember]
        public int Rid { set; get; }
        [DataMember]
        public double Quantity { set; get; }
        [DataMember]
        public double Price { set; get; }
    }
}
