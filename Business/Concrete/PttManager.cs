using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService) 
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Vatandas vatandas)
        {
            if (_applicantService.CheckVatandas(vatandas))
            {
                Console.WriteLine(vatandas.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(vatandas.FirstName + " için maske verilemedi");
            }
        }
    }
}
