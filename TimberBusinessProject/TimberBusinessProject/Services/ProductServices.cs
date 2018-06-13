using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimberBusinessProject.Models;

namespace TimberBusinessProject.Services
{
    public class ProductServices
    {
        private static ProductServices _instace;

        public static ProductServices GetInstance
        {
            get
            {
                if (_instace == null)
                {
                    _instace = new ProductServices();
                }

                return _instace;
            }
        }
        public int updateBamboo(bamboo bamboo)
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return (int)context.Update(bamboo);
            }
        }

        public int updateWoodProp(WoodProp prop)
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return (int)context.Update(prop);
            }
        }

        public List<plywood> GetPlywood()
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<plywood>("select * from plywood");
            }
        }
        public List<pinewood> GetPinewood()
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<pinewood>("select * from pinewood");
            }
        }

        public List<bamboo> GetBamboo()
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<bamboo>("select * from bamboo");
            }
        }

        public pinewood GetPinewoodByID(int id)
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<pinewood>("select * from pinewood where id = @0", id).FirstOrDefault();
            }
        }
        public BsmbooModel GetBambooByID(int id)
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<BsmbooModel>("select * from bamboo where id = @0", id).FirstOrDefault();
            }
        }

        public WoodProp GetWoodPropByID(int id)
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<WoodProp>("select * from WoodProp where id = @0", id).FirstOrDefault();
            }
        }

        public woodpropModel GetWoodModelPropByID(int id)
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<woodpropModel>("select * from WoodProp where id = @0", id).FirstOrDefault();
            }
        }

        public bamboo GetBambooDetailByID(int id)
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<bamboo>("select * from bamboo where id = @0", id).FirstOrDefault();
            }
        }

        public List<WoodProp> getWoodProps()
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<WoodProp>("select * from WoodProp");
            }
        }

        public List<woodpropModel> getWoodPropsWithPrice()
        {
            using (PetaPoco.Database context = new PetaPoco.Database("DefaultConnection"))
            {
                return context.Fetch<woodpropModel>("select * from WoodProp");
            }
        }
    }
}