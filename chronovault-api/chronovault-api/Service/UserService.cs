using chronovault_api.Infra.Data;
using chronovault_api.Mappers;
using chronovault_api.Model.Response;
using chronovault_api.Service.Interfaces;

namespace chronovault_api.Service {
    public class UserService : IUserService {
        private ChronovaultDbContext _dbContext;

        public UserService(ChronovaultDbContext dbContext) {
            _dbContext = dbContext;
        }
        public List<UserViewModel> GetAllUsers() {
            var users = _dbContext.Users.ToList();
            return UserMapper.ToViewmodelList(users);
        }

        public UserViewModel GetUserById(int id) {
            var existentUser = _dbContext.Users.FirstOrDefault(p => p.Id == id);

            if (existentUser == null){
                throw new Exception("Usuário não existe");
            }
            return UserMapper.ToViewmodel(existentUser);
        }
    }
}