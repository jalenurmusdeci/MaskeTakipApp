using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class YabancıManager : IApplicantService
    {
        public void ApplyForMask(Vatandas vatandas)
        {
            throw new NotImplementedException();
        }

        public bool CheckVatandas(Vatandas vatandas)
        {
            throw new NotImplementedException();
        }

        public List<Vatandas> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
