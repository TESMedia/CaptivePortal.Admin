using CaptivePortal.API.Context;
using CaptivePortal.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CaptivePortal.API.Controllers
{
    public class AdminManagementController : Controller
    {

        AdminManagementDbContext db =new AdminManagementDbContext();

        //private AdminManagementDbContext db = new AdminManagementDbContext();

        string retString = "-1";
        [HttpPost]
        [Route("GAlogin")]
        public async Task<ActionResult> GALogin(LoginViewModel admin)
        {
            try
            {
                if (!string.IsNullOrEmpty(admin.Email) && !string.IsNullOrEmpty(admin.UserPassword))
                {
                    AdminManagementModel user = db.AdminManagementModels.Where(m => m.Email == admin.Email).FirstOrDefault();
                    if (user != null)
                    {
                        retString = Convert.ToString(user);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index", "AdminIndex");
        }

        // GET: AdminManagement
        public ActionResult Login()
        {
            return View();
        }

    }
}