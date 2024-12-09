using velocitaApi.models;

namespace velocitaApi.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}
