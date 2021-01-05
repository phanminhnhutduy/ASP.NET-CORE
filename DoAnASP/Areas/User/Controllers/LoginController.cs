using DoAnASP.Areas.Admin.Models;
using DoAnASP.Areas.User.Data;
using EmptyProject_Test.Areas.Admin.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP.Areas.User.Controllers
{
    [Area("User")]
    public class LoginController : Controller
    {
       
        private readonly DpContext _context;

        public LoginController(DpContext context)
        {
            _context = context;
        }
        static int i = 0;
        public IActionResult Index()
        {
            if (i != 0)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                ViewBag.sessionUser = us.SelectToken("Ten").ToString();

            }

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(TaiKhoan taikhoan)
        {

            var r = _context.TaiKhoans.FirstOrDefault(m => m.Ten == taikhoan.Ten && m.Password == StringProcess.CreateMD5Hash(taikhoan.Password));
            if (r == null )
            {
                return View("Index");
            }
            var str = JsonConvert.SerializeObject(r);
            HttpContext.Session.SetString("user", str);
            i++;
            if ( r.Quyen == 0)
            {
                var url = Url.RouteUrl(new { controller = "Home", action = "Index", area = "Admin" });
                return Redirect(url);
            }
            var urll = Url.RouteUrl(new { controller = "Home", action = "Index", area = "User" });
            return Redirect(urll);
        }
    }
}
