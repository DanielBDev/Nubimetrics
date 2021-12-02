using Domain.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructure.Configuration
{
    internal class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(n => n.Nombre).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Apellido).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(50).IsRequired();

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[20];
            var random = new Random();
            var users = new List<User>();

            for (int i = 1; i <= 20; i++)
            {
                users.Add(new User
                {
                    Id = i,
                    Nombre = $"User{i}",
                    Apellido = $"Apellido{i}",
                    Email = $"user{i}@correo.com",
                    Password = new string(Enumerable.Repeat(chars, stringChars.Length).Select(s => s[random.Next(s.Length)]).ToArray())
                });
            }

            builder.HasData(users);
        }
    }
}