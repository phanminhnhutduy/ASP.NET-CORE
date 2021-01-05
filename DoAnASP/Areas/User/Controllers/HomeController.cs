using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnASP.Areas.Admin.Models;
using DoAnASP.Areas.User.Data;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DoAnASP.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        static int i = 0;
        private readonly DpContext _context;
        public bool tim = false;
        public HomeController(DpContext context)
        {
            _context = context;
        }

        // GET: User/Blogs
        public async Task<IActionResult> Index(string TimKiem)
        {
            var dpContext = _context.Blogs.Include(b => b.loai);
            ViewBag.Loai = _context.Loais;           
            ViewBag.blogs = _context.Blogs;        
            ViewBag.cauhois = _context.CauHois;
            ViewBag.TaiKhoan = _context.TaiKhoans;

           
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe");
            ViewData["IDTK"] = new SelectList(_context.TaiKhoans, "IDTK", "Ten");
            ViewData["IDNguoiTao"] = new SelectList(_context.TaiKhoans, "IDTK", "Ten");
           
            return View(await dpContext.ToListAsync());
        }    
public async Task<IActionResult> timkim(string searchString)
        {
            var doctors = from m in _context.Blogs
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                doctors = doctors.Where(s => s.TieuDe.Contains(searchString));
            }
            tim = true;
            return View(await doctors.ToListAsync());
        }
    }
}
