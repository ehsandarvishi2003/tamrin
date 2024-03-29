﻿using System.ComponentModel.DataAnnotations;

namespace tamrin.DTOs
{
    public class UserLoginDTO
    {
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

}
