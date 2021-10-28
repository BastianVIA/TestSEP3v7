using Client.Data;

namespace Client.Models {
public interface IUserService {
    User ValidateUser(string userName, string password);
}
}