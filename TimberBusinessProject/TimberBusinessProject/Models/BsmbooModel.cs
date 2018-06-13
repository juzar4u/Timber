using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimberBusinessProject.Models
{
    public class BsmbooModel
    {
        public int ID { get; set; }
        public string qtykey { get; set; }
        public string Name { get; set; }
        public int Length_ft { get; set; }
        public int Price { get; set; }
        public int ActualPrice { get; set; }
        public DateTime DateOfActualPrice { get; set; }
        public string DateStringActualPrice { get; set; }
    }

    public class BambooItemsModel
    {
        public int id { get; set; }
        public int ActualCostPrice { get; set; }
    }

    public class woodpropModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Length_ft { get; set; }
        public int Price { get; set; }
        public DateTime PriceUpdatedOn { get; set; }
        public string PriceUpdatedOnString { get; set; }
    }
}