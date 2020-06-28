using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFOLD.Models;

namespace WPFOLD.Daos.IDaos
{
    public interface IRegionDAO
    {
        List<Region> Get();
        bool Insert(Region region);
    }
}
