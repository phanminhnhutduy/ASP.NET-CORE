        using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoAnASP.Areas.Admin.Models;
using DoAnASP.Areas.User.Data;
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DoAnASP.Areas.User.Controllers
{
    [Area("User")]
    public class BlogsController : Controller
    {
       
        private readonly DpContext _context;
        public bool tim = false;
        public BlogsController(DpContext context)
        {
            _context = context;
        }
        static int idbaiviet;
        // GET: User/Blogs
        public async Task<IActionResult> Index(int ? page=0)
        {

                var dpContext = _context.Blogs.Include(b => b.loai).OrderByDescending(a=>a.View);
                ViewBag.Loai = _context.Loais;
                ViewBag.TaiKhoan = _context.TaiKhoans;
          

            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe");
           
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                ViewBag.UerName = us.SelectToken("Ten").ToString();
                ViewBag.IDName = us.SelectToken("IDTK").ToString();
                ViewBag.IDTen = us.SelectToken("Ten").ToString();
            }
            return View(await dpContext.ToListAsync());            
        }
        static int kq=0;
       
        // GET: User/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            

            if (kq != 0)
                id = idbaiviet;
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                ViewBag.IDName = us.SelectToken("IDTK").ToString();
            } 
                     
            if (id == null)
            {
                return NotFound();
            }
            kq = 0;
            var blog = await _context.Blogs
                .Include(b => b.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            blog.View = blog.View + 1;          
            if (blog == null)
            {
                return NotFound();
            }
           await _context.SaveChangesAsync();
            ViewBag.Loai = _context.Loais;
            ViewBag.BinhLuan = _context.BinhLuans;

            var tenngtao = from s in _context.BinhLuans
                           join r in _context.TaiKhoans on s.IDTK equals r.IDTK
                           join w in _context.Blogs on s.IDBV equals w.IDBlog
                           select new
                           {                             
                               r.Ten,
                               r.HinhAnh
                           };
            foreach (var item in tenngtao)
            {
                ViewBag.ten = item.Ten.ToString();
                ViewBag.hinh = item.HinhAnh.ToString();
            }
           

            return View(blog);
        }      
        //public async Task<IActionResult> DetailsPost()
        //{
        //    kq = kq +1;
        //    idbaiviet = int.Parse(HttpContext.Session.GetString("idbaiviet").ToString());
        //    HttpContext.Session.Remove("idbaiviet");
        //    if (idbaiviet == null)
        //    {
        //        return NotFound();
        //    }
        //    var blog = await _context.Blogs
        //        .Include(b => b.loai)
        //        .FirstOrDefaultAsync(m => m.IDBlog == idbaiviet);
        //   // blog.View = Int32.Parse(HttpContext.Session.GetString("view"));
        //    if (blog == null)
        //    {
        //        return NotFound();
        //    }
        //    await _context.SaveChangesAsync();           
        //    ViewBag.Loai = _context.Loais;
        //    ViewBag.BinhLuan = _context.BinhLuans;
        //    return RedirectToAction("Details");
        //}
        // GET: User/Blogs/Create
        public IActionResult Create()
        {
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));          
            ViewBag.IDName = us.SelectToken("IDTK").ToString();
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe");
            return View();
        }
        // POST: User/Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] Blog blog , IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                await _context.SaveChangesAsync();
                if (blog.HinhAnh != null)
                {
                    var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/blog", blog.IDBlog + "." +
                    ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                    using (var stream = new FileStream(parth, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    blog.HinhAnh = blog.IDBlog + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    _context.Update(blog);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe", blog.IDLoai);
            return View(blog);
        }

        // GET: User/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Loai = _context.Loais;
            if (id == null)
            {
                return NotFound();
            }
            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe", blog.IDLoai);
            return View(blog);
        }

        // POST: User/Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] Blog blog, IFormFile ful)
        { 
            if (id != blog.IDBlog)
            {
                return NotFound();
            }
           
          
            if (ModelState.IsValid)
            {
                try
                {
                    if (blog.HinhAnh != null)
                    {
                        _context.Update(blog);
                        var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/blog", blog.IDBlog + "." +
                   ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(parth, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        blog.HinhAnh = blog.IDBlog + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    }
                        _context.Update(blog);

                    await _context.SaveChangesAsync();
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.IDBlog))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe", blog.IDLoai);
            return View(blog);
        }

        // GET: User/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = await _context.Blogs
                .Include(b => b.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        // POST: User/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.IDBlog == id);
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
   
        public async Task<IActionResult> Xoa(int id)
        {
            var duyettrangthai = _context.Blogs.Find(id);
            duyettrangthai.TrangThai = 3;
           
            _context.Update(duyettrangthai);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Blogs");
            //return View(blog);
        }
        public async Task<IActionResult> hoangtac(int id)
        {
            var duyettrangthai = _context.Blogs.Find(id);
            duyettrangthai.TrangThai = 1;

            _context.Update(duyettrangthai);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Blogs");
            //return View(blog);
        }
    }
}
