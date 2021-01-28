using IdentityValidate.Entities;

namespace IdentityValidate.Abstract
{
    internal interface ICitizenService
    {
        bool Validate(Citizen citizen);
    }
}