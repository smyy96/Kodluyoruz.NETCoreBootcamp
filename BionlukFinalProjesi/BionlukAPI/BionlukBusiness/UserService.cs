using AutoMapper;
using Bionluk.DataAccess;
using Bionluk.DataTransferObjects.Request;
using Bionluk.DataTransferObjects.Responses;
using Bionluk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.Business
{
    public class UserService: IUserService
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private List<User> users;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public async Task<int> AddUser(AddUserRequest user)
        {
            var users= mapper.Map<User>(user);
            await userRepository.AddUser(users);
            return users.Id;

        }

        public async Task DeleteUser(int id)
        {
           await userRepository.DeleteUser(id);
        }

        public async Task<UserDisplayResponse> GetUser(int id)
        {
            var user=await userRepository.GetById(id);
            var userDisplayResponse = mapper.Map<UserDisplayResponse>(user);
            return userDisplayResponse;
        }

        public async Task<IList<UserDisplayResponse>> GetUserByName(string search)
        {
            var user = await userRepository.GetUsersByName(search);
            var result = mapper.Map<IList<UserDisplayResponse>>(user);
            return result;
        }

        public async Task<IList<UserDisplayResponse>> GetUsers()// users içindeki kullanıcıları döndürüyor.
        {
            var users= await userRepository.GetAll();
            var result= mapper.Map<IList<UserDisplayResponse>>(users);
            return result;
        }

        public async Task<bool> IsUserExists(int id)
        {
            return await userRepository.IsExists(id);
        }

        public async Task UpdateUser(UpdateUserRequest user)
        {
            var users=mapper.Map<User>(user);
            await userRepository.UpdateUser(users);
        }
    }
}
