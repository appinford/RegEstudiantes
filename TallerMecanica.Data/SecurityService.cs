﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TallerMecanica.Model;

namespace TallerMecanica.Data
{
    public class SecurityService
    {
        public List<Usuario> usuarios;
        public SecurityService()
        {
            usuarios = new List<Usuario>();

            usuarios.Add(new Usuario
            {
                Id = 1,
                Nombre = "Bielka",
                Apellido = "Batista",
                Login = "bielkb",
                Password = "123",
                Rol = "Super"
            });

            usuarios.Add(new Usuario
            {
                Id = 1,
                Nombre = "Administrador",
                Apellido = "Del Sistema",
                Login = "admin",
                Password = "123",
                Rol = "Admin"
            });

        }
        public Usuario VerificarCredenciales(string login, string password)
        {
            return usuarios.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
    }
}

