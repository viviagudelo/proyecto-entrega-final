﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySmallBusiness.Models
{
    public class Category
    {
        public int ID { get; set; }  
        public string CategoryName { get; set; }

        public virtual ICollection<Entrepreneurship> Entrepreneurships { get; set; }
    }

}