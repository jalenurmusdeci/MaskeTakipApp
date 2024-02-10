using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {

        void ApplyForMask(Vatandas vatandas);
      
        List<Vatandas> GetList();

        bool CheckVatandas(Vatandas vatandas);
        
    }
}
