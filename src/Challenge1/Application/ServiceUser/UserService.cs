using Application.DTOs.User;
using Application.Wrappers;
using AutoMapper;
using Domain.User;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.ServiceUser
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public UserService(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        public async Task<Response<int>> DeleteById(int id)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(k => k.Id == id);

            if (user == null)
            {
                throw new KeyNotFoundException($"El registro '{id}' no fue encontrado");
            }

            _applicationDbContext.Remove(user);

            await _applicationDbContext.SaveChangesAsync();

            return new Response<int>(user.Id, "Usuario eliminado con éxito.");
        }

        public async Task<Response<List<UserDto>>> GetAll()
        {
            var user = await _applicationDbContext.Users.ToListAsync();

            var userDto = _mapper.Map<List<UserDto>>(user);

            return new Response<List<UserDto>>(userDto);
        }

        public async Task<Response<UserDto>> GetById(int id)
        {
            var user = await _applicationDbContext.Users.FirstOrDefaultAsync(k => k.Id == id);

            if (user == null)
            {
                throw new KeyNotFoundException($"El registro '{id}' no fue encontrado");
            }

            var userDto = _mapper.Map<UserDto>(user);

            return new Response<UserDto>(userDto);
        }

        public async Task<Response<UserDto>> Insert(UserDto user)
        {
            var newUser = _mapper.Map<User>(user);

            await _applicationDbContext.AddAsync(newUser);
            await _applicationDbContext.SaveChangesAsync();

            var userDto = _mapper.Map<UserDto>(newUser);

            return new Response<UserDto>(userDto, "Usuario insertado con éxito.");
        }

        public async Task<Response<UserDto>> Update(UserDto user)
        {
            var updateUser = await _applicationDbContext.Users.FirstOrDefaultAsync(k => k.Id == user.Id);

            if (user == null)
            {
                throw new KeyNotFoundException($"El registro '{user.Id}' no fue encontrado");
            }

            updateUser.Nombre = user.Nombre;
            updateUser.Apellido = user.Apellido;
            updateUser.Email = user.Email;
            updateUser.Password = user.Password;

            await _applicationDbContext.SaveChangesAsync();

            var userDto = _mapper.Map<UserDto>(updateUser);

            return new Response<UserDto>(userDto, "Usuario modificado con éxito.");
        }
    }
}