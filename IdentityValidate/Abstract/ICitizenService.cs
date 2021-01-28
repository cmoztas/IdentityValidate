using IdentityValidate.Entities;

namespace IdentityValidate.Abstract
{
    internal interface ICitizenService
    {
        void Validate(Citizen citizen);
    }
}