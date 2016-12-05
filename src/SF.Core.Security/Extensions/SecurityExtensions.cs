﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SF.Core.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using SF.Core.Security.Filters;
using SF.Core.Security.Attributes;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace SF.Core.Security
{
    public class SecurityExtensions : ModuleInitializerBase
    {
        public override IEnumerable<KeyValuePair<int, Action<IServiceCollection>>> ConfigureServicesActionsByPriorities
        {
            get
            {
                return new Dictionary<int, Action<IServiceCollection>>()
                {
                    [10000] = this.AddSecuritys,
     
                };
            }
        }

        public override IEnumerable<KeyValuePair<int, Action<IApplicationBuilder>>> ConfigureActionsByPriorities
        {
            get
            {
                return new Dictionary<int, Action<IApplicationBuilder>>()
                {
                    [0]=this.UseSecurity,
                };
            }
        }


        /// <summary>
        /// 插件基本服务注册
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public void AddSecuritys(IServiceCollection services)
        {
            services.AddScoped<IAuthorizationHandler, RolesPermissionsHandler>();
            services.AddScoped<IAuthorizationHandler, PermissionHandler>();

            services.TryAddTransient<IFilterProvider, DependencyFilterProvider>();
            services.TryAddTransient<IFilterMetadata, AdminFilter>();
            services.AddSingleton<IPermissionProvider, GobalPermissions>();
            services.AddSingleton<IPermissionScopeService, PermissionScopeService>();
            services.AddSingleton<ISecurityService, SecurityService>();
            services.AddSingleton<IPermissionProvider>(sp =>
            {
                return sp.GetRequiredService<GobalPermissions>();
            });
        }

        public void UseSecurity(IApplicationBuilder applicationBuilder)
        {
            // Ensure the shell tenants are loaded when a request comes in
            // and replaces the current service provider for the tenant's one.
           

        }

    }
}
