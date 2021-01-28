using System;
using IdentityValidate.Abstract;
using IdentityValidate.Entities;
using IdentityValidateService;
using System.Threading.Tasks;

namespace IdentityValidate.Managers
{
    internal class CitizenManager : ICitizenService
    {
        private readonly IdentityValidateService.KPSPublicSoapClient _client;

        public CitizenManager(KPSPublicSoapClient client)
        {
            _client = client;
        }

        public bool Validate(Citizen citizen)
        {
            try
            {
                Task<TCKimlikNoDogrulaResponse> response = _client.TCKimlikNoDogrulaAsync(citizen.IdentityNumber, citizen.Name, citizen.Surname,
                    citizen.BirthYear);
                    return response.Result.Body.TCKimlikNoDogrulaResult;
            }
            catch (Exception e)
            {
                Console.WriteLine("Sistemde bir sorun oluştu.");
                return false;
            }
        }
    }
}