using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Moldel;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string userName);

        bool RevokeToken(string userName);

        public User RefreshUserInfo(User user);

    }
}
