﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Construction.singleton;
namespace Construction
{
    class Test
    {
        public void initialize()
        {
            Database.creatInstance("localhost");
            
        }
    }
}
