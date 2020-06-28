using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFOLD.Daos;
using WPFOLD.Models;

namespace WPFOLD.Controllers
{
    public class RegionController
    {
        RegionDAO regionDAO = new RegionDAO();

        public List<Region> Get()
        {
            if (regionDAO.Get().Equals(0))
            {
                return null;
            }
            else
            {
                return regionDAO.Get();
            }
        }

        public bool Insert(string name)
        {
            Region region = new Region()
            {
                Name = name
            };
            return regionDAO.Insert(region) ?
                true : false;
        }
    }
}
