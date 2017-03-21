using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CaptivePortal.API.Models;

namespace CaptivePortal.API.Context
{
    public class AdminManagementDbContext:DbContext
    {
        public AdminManagementDbContext() : base("name=CaptivePortalDB")
        {

        }
        //public DbSet<AdminManagementModel> AdminManagementModels { get; set; }
        public DbSet<UserInfo> UserInfoModels { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}