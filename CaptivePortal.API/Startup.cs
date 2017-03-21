using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using CaptivePortal.API.Context;
using CaptivePortal.API.Models;

[assembly: OwinStartup(typeof(CaptivePortal.API.Startup))]

namespace CaptivePortal.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //AdminManagementDbOperation objAdminManagementDbOperation = new AdminManagementDbOperation();
            //objAdminManagementDbOperation.PerformDatabaseOperations();
        }
    }
}
