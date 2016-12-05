﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SF.Core.Abstraction.Data;
using SF.Core.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using SF.Core.Security;

namespace SF.Module.Backend.Controllers
{

    [Authorize(Roles = "admin")]
    [Route("api/users")]
    public class SecurityController : Core.Web.Base.Controllers.ControllerBase
    {

        private readonly ISecurityService _securityService;
        public SecurityController(
            ISecurityService securityService,
            IServiceCollection service,
            ILogger<UserApiController> logger) : base(service, logger)
        {

            this._securityService = securityService;
        }
        
    }
}
