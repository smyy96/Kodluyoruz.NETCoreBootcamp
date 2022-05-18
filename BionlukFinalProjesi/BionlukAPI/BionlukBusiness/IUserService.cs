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
    }
}
