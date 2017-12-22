using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySmallBusiness.Models
{
    public class Entrepreneurship
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }


        }

    }
