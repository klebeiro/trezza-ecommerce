using chronovault_api.Model.Request;
using chronovault_api.Model.Response;

namespace chronovault_api.Service.Interfaces {
    public interface IUserService {
        List<UserViewModel> GetAllUsers();

        UserViewModel GetUserById(int id);
        
        void CreateUser(UserCreateRequest request);
        
        void UpdateUser(UserUpdateRequest request);
    }
}
