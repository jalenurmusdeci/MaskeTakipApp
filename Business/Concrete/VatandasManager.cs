using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VatandasManager : IApplicantService 
    {
        public void ApplyForMask(Vatandas vatandas)
        {

        }
        public List<Vatandas> GetList()
        {
            return null;
        }
        public bool CheckVatandas(Vatandas vatandas)
        {
            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody
                (vatandas.NationalIdentity, vatandas.FirstName, vatandas.LastName, vatandas.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
