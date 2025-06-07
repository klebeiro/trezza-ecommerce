using chronovault_api.Infra.Data;
using chronovault_api.Mappers;
using chronovault_api.Model.Request;
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

        public UserViewModel GetUserById(int id)
        {
            var existentUser = _dbContext.Users.FirstOrDefault(p => p.Id == id);

            if (existentUser == null)
            {
                throw new Exception("Usuário não existe");
            }

            return UserMapper.ToViewmodel(existentUser);
        }

        public void CreateUser(UserCreateRequest request)
        {
            var existentUser = _dbContext.Users.FirstOrDefault(u=>u.Email==request.Email);
            
            if (existentUser != null)
            {
                throw new Exception("Email já está em uso");
            }

            _dbContext.Users.Add(UserMapper.ToEntity(request));
            _dbContext.SaveChanges();
        }

        public void UpdateUser(UserUpdateRequest request)
        {
            var existentUser = _dbContext.Users.FirstOrDefault(p => p.Id == request.Id);
            if (existentUser == null)
            {
                throw new Exception("Usuario não encontrado");
            }
            existentUser.Email = request.Email??existentUser.Email;
            existentUser.Nome = request.Nome??existentUser.Nome;
            existentUser.Senha = request.Senha??existentUser.Senha;
            _dbContext.SaveChanges();
        }
    }
}