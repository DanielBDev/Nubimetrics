using Application.DTOs.User;
using Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceUser
{
    public interface IUserService
    {
        Task<Response<List<UserDto>>> GetAll();

        Task<Response<UserDto>> GetById(int id);

        Task<Response<UserDto>> Insert(UserDto user);

        Task<Response<UserDto>> Update(UserDto user);

        Task<Response<int>> DeleteById(int id);
    }
}