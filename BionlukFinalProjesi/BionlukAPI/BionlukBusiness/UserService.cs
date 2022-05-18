using AutoMapper;
using Bionluk.DataAccess;
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


        public async Task<IList<UserDisplayResponse>> GetUsers()// users içindeki kullanıcıları döndürüyor.
        {
            var users= await userRepository.GetAll();
            var result= mapper.Map<IList<UserDisplayResponse>>(users);
            return result;
        }

    }
}
