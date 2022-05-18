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
    public interface IUserService
    {
        Task<IList<UserDisplayResponse>> GetUsers();
        Task<UserDisplayResponse> GetUser(int id);
        Task<IList<UserDisplayResponse>> GetUserByName(string search);
        Task<int> AddUser(AddUserRequest user);
        Task UpdateUser(UpdateUserRequest user);
        Task DeleteUser(int id);
        Task<bool> IsUserExists(int id);
    }
}
