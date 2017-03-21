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
                    if (db == null)
                    {
                        var admin = new AdminManagementModel
                        {
                            Id = 1,
                            Email = "captive@loc8.com",
                            Password = "Tes@123"
                        };

                        db.AdminManagementModels.Add(admin);
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