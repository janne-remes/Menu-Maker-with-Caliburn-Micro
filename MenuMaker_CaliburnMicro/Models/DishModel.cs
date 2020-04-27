using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace MenuMaker_CaliburnMicro.Models
{
    public class DishModel
    {

        public int DishID { get; set; }
        public string DishName { get; set; }

        public string DishDescription { get; set; }

        public double DishPrice { get; set; }
    }
}
