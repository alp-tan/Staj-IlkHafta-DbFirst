using C__301_DataAccesLayer.Abstract;
using C__301_DataAccesLayer.Repositories;
using C__301EmptityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__301_DataAccesLayer.EntitiyFrameWork
{
    public class EfAdminDal : Generic_Repository<Admin>,IAdminDal
    {
    }
}
