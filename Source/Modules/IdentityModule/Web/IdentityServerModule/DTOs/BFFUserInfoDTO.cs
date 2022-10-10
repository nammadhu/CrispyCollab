﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Modules.IdentityModule.Web.DTOs
{
    public class BFFUserInfoDTO
    {
        public static readonly BFFUserInfoDTO Anonymous = new BFFUserInfoDTO();
        public List<ClaimValueDTO> Claims { get; set; }
    }
}
