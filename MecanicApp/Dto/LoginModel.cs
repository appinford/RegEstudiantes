﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecanicApp.Dto
{
    public class LoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Recordarme { get; set; }
    }
}
