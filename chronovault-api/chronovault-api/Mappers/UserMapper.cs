using chronovault_api.Model.Response;
using chronovault_api.Model;
using chronovault_api.Model.Request;

namespace chronovault_api.Mappers {
    public static class UserMapper {
        public static UserViewModel ToViewmodel(User model) {
            return new UserViewModel {
                Nome = model.Nome,
                Email = model.Email,
                Id = model.Id
            };

        }
        public static List<UserViewModel> ToViewmodelList(List<User> modelList) {
            var userViewmodels = new List<UserViewModel>();

            foreach (var model in modelList) {
                userViewmodels.Add(
                    new UserViewModel {
                        Nome = model.Nome,
                        Email = model.Email,
                        Id = model.Id
                    }
                );
            }

            return userViewmodels;
        }

        public static User ToEntity(UserCreateRequest model)
        {
            return new User()
            {
                Email = model.Email,
                Nome = model.Nome,
                Senha = model.Senha,
            };
        }

    }
}
