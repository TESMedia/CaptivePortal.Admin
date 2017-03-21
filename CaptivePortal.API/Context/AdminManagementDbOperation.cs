using CaptivePortal.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptivePortal.API.Context
{
    public class AdminManagementDbOperation
    {
        public void PerformDatabaseOperations()
        {
            try
            {
                using (var db = new AdminManagementDbContext())
                {
                    var admin = db.UserInfoModels.Where(i => i.email == "captive@loc8.com").ToList();
                    if (admin.Count != 1)
                    {
                        var user = new UserInfo
                        {
                            email = "captive@loc8.com",
                            password = "Tes@123"
                        };

                        db.UserInfoModels.Add(user);
                        db.SaveChanges();

                        UserRole objUserRole = new UserRole();
                        var adminInfo = db.UserInfoModels.Where(i => i.email == "captive@loc8.com").FirstOrDefault();
                        objUserRole.id = user.id;
                        var role = db.Roles.Where(i => i.RoleName == "GAdmin").FirstOrDefault();
                        objUserRole.RoleId = role.RoleId;
                        db.UserRoles.Add(objUserRole);
                        db.SaveChanges();
                    }
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}