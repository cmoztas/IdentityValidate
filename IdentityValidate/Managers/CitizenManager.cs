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

        public void Validate(Citizen citizen)
        {
            try
            {
                Task<TCKimlikNoDogrulaResponse> response = _client.TCKimlikNoDogrulaAsync(citizen.IdentityNumber, citizen.Name, citizen.Surname,
                    citizen.BirthYear);

                bool result = response.Result.Body.TCKimlikNoDogrulaResult;

                Console.WriteLine( result
                    ? "\nGirilen bilgiler doğrulandı."
                    : "\nGirilen bilgiler doğrulanamadı.");
            }
            catch
            {
                Console.WriteLine("Sistemde bir sorun oluştu.");
            }
        }
    }
}