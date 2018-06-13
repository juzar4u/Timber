using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimberBusinessProject.Models;

namespace TimberBusinessProject.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/products
        public List<plywood> GetPlywood()
        {
            List<plywood> plywood = new List<plywood>();
            plywood = Services.ProductServices.GetInstance.GetPlywood();

            return plywood;
        }
        public List<pinewood> GetPinewood()
        {
            List<pinewood> pinewoodModel = new List<pinewood>();
            pinewoodModel = Services.ProductServices.GetInstance.GetPinewood();

            return pinewoodModel;
        }

        public List<bamboo> GetBamboo()
        {
            List<bamboo> bamboo = new List<bamboo>();
            bamboo = Services.ProductServices.GetInstance.GetBamboo();

            return bamboo;
        }

        public pinewood GetPineWoodDetail(int id)
        {
            pinewood pinewoodModel = new pinewood();
            pinewoodModel = Services.ProductServices.GetInstance.GetPinewoodByID(id);

            return pinewoodModel;
        }

        public BsmbooModel GetBambooDetail(int id)
        {
            BsmbooModel bambooModel = new BsmbooModel();
            bambooModel = Services.ProductServices.GetInstance.GetBambooByID(id);
            bambooModel.qtykey = string.Format("bambooQty{0}", id);
            bambooModel.DateOfActualPrice = bambooModel.DateOfActualPrice;
            bambooModel.DateStringActualPrice = bambooModel.DateOfActualPrice.Year > 2001 ? bambooModel.DateOfActualPrice.Date.ToString("dd/MM/yyyy") : "Not Updated";
            return bambooModel;
        }

        public List<WoodProp> GetWoodProp()
        {
            List<WoodProp> woodprops = new List<WoodProp>();
            woodprops = Services.ProductServices.GetInstance.getWoodProps();
            
            return woodprops;
        }

        public List<woodpropModel> GetWoodPropWithPrice()
        {
            List<woodpropModel> woodprops = new List<woodpropModel>();
            woodprops = Services.ProductServices.GetInstance.getWoodPropsWithPrice();
            foreach (var item in woodprops)
            {
                item.PriceUpdatedOnString = item.PriceUpdatedOn.Year > 2001 ? item.PriceUpdatedOn.Date.ToString("dd/MM/yyyy") : "Not Updated";
            }
            return woodprops;
        }

        public woodpropModel GetWoodPropDetail(int id)
        {
            woodpropModel woodpropModel = new woodpropModel();
            woodpropModel = Services.ProductServices.GetInstance.GetWoodModelPropByID(id);
            woodpropModel.PriceUpdatedOnString = woodpropModel.PriceUpdatedOn.Year > 2001 ? woodpropModel.PriceUpdatedOn.Date.ToString("dd/MM/yyyy") : "Not Updated";
            return woodpropModel;
        }

        [HttpPost]
        public int addBamboo(int id, int ac)
        {
            bamboo bambooModel = new bamboo();
            bambooModel = Services.ProductServices.GetInstance.GetBambooDetailByID(id);
            bambooModel.ActualPrice = ac;
            bambooModel.DateOfActualPrice = DateTime.Now;
            Services.ProductServices.GetInstance.updateBamboo(bambooModel);
            return 0;
        }

        [HttpPost]
        public int addWoodProp(int id, int ac)
        {
            WoodProp woodProp = new WoodProp();
            woodProp = Services.ProductServices.GetInstance.GetWoodPropByID(id);
            woodProp.Price = ac;
            woodProp.PriceUpdatedOn = DateTime.Now;
            Services.ProductServices.GetInstance.updateWoodProp(woodProp);
            return 0;
        }

        // GET api/products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/products
        public void Post([FromBody]string value)
        {
        }

        // PUT api/products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/products/5
        public void Delete(int id)
        {
        }
    }
}
