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
    public class CauHoisController : Controller
    {
        static int i = 0;
        private readonly DpContext _context;
        static int idcauhoi;
        public CauHoisController(DpContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string TimKim )
        {
            var dpContext = _context.CauHois.Include(b => b.loai).OrderByDescending(a => a.View);
            CauHoi cauhoi = new CauHoi();
            ViewBag.Loai = _context.Loais;
            ViewBag.TaiKhoan = _context.TaiKhoans;
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe", cauhoi.IDLoai);
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                ViewBag.UerName = us.SelectToken("Ten").ToString();
                ViewBag.IDName = us.SelectToken("IDTK").ToString();
            }
            return View(await dpContext.ToListAsync());
        }
        public async Task<IActionResult> Index1(string TimKim)
        {
            var dpContext = _context.CauHois.Include(b => b.loai).OrderByDescending(a => a.View);
            CauHoi cauhoi = new CauHoi();
            ViewBag.Loai = _context.Loais;
            ViewBag.TaiKhoan = _context.TaiKhoans;
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe", cauhoi.IDLoai);
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                ViewBag.UerName = us.SelectToken("Ten").ToString();
                ViewBag.IDName = us.SelectToken("IDTK").ToString();
            }
            return View(await dpContext.ToListAsync());
        }


        static int kq = 0;
        // GET: User/CauHois/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (kq != 0)
            id = idcauhoi;
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                HttpContext.Session.SetString("idcauhoi", id.ToString());
                ViewBag.IDName = us.SelectToken("IDTK").ToString();
            }
          
            if (id == null)
            {
                return NotFound();
            }
            var cauhoi = await _context.CauHois
                .Include(b => b.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            cauhoi.View = cauhoi.View + 1;
            if (cauhoi == null)
            {
                return NotFound();
            }
            await _context.SaveChangesAsync();
            ViewBag.Loai = _context.Loais;
            ViewBag.BinhLuanCH = _context.BinhLuanCHs;

            var tenngtao = from s in _context.BinhLuanCHs
                           join r in _context.TaiKhoans on s.IDTK equals r.IDTK
                           join w in _context.CauHois on s.IDCH equals w.IDBlog
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



            return View(cauhoi);
        }
        //public async Task<IActionResult> DetailsPost()
        //{
        //   kq = kq + 1;
        //   idcauhoi = int.Parse(HttpContext.Session.GetString("idcauhoi").ToString());
        //    if (idcauhoi == null)
        //    {
        //        return NotFound();
        //    }
        //    var cauHoi = await _context.CauHois
        //        .Include(b => b.loai)
        //        .FirstOrDefaultAsync(m => m.IDBlog == idcauhoi);
        //    cauHoi.View = Int32.Parse(HttpContext.Session.GetString("viewch"));
        //    if (cauHoi == null)
        //    {
        //        return NotFound();
        //    }
        //    await _context.SaveChangesAsync();
        //    ViewBag.Loai = _context.Loais;
        //    ViewBag.BinhLuanCH = _context.BinhLuanCHs;
        //    return RedirectToAction("Details");
        //}
        // GET: User/CauHois/Create
        public IActionResult Create()
        {
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            ViewBag.IDName = us.SelectToken("IDTK").ToString();
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe");
            return View();
        }

        // POST: User/CauHois/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] CauHoi cauhoi, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cauhoi);
                await _context.SaveChangesAsync();
                if (cauhoi.HinhAnh != null)
                {


                    var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cauhoi", cauhoi.IDBlog + "." +
                    ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                    using (var stream = new FileStream(parth, FileMode.Create))
                    {
                        await ful.CopyToAsync(stream);
                    }
                    cauhoi.HinhAnh = cauhoi.IDBlog + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    _context.Update(cauhoi);
                }
                    await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "TieuDe", cauhoi.IDLoai);
            return View(cauhoi);
        }

        // GET: User/CauHois/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Loai = _context.Loais;
            if (id == null)
            {
                return NotFound();
            }
            var cauhoi = await _context.CauHois.FindAsync(id);
            if (cauhoi == null)
            {
                return NotFound();
            }
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", cauhoi.IDLoai);
            return View(cauhoi);
        }

        // POST: User/CauHois/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDBlog,TieuDe,HinhAnh,TomTat,NoiDung,IDLoai,IDNguoiTao,NgayTao,NgayDuyet,View,IDNguoiDuyet,TrangThai")] CauHoi cauhoi ,IFormFile ful)
        {
            if (id != cauhoi.IDBlog)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (cauhoi.HinhAnh != null)
                    {
                        _context.Update(cauhoi);
                        var parth = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cauhoi", cauhoi.IDBlog + "." +
                   ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1]);
                        using (var stream = new FileStream(parth, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        cauhoi.HinhAnh = cauhoi.IDBlog + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                    }
                    _context.Update(cauhoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cauhoiExists(cauhoi.IDBlog))
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
            ViewData["IDLoai"] = new SelectList(_context.Loais, "IDLoai", "IDLoai", cauhoi.IDLoai);
            return View(cauhoi);
        }
        // GET: User/CauHois/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cauhoi = await _context.CauHois
                .Include(b => b.loai)
                .FirstOrDefaultAsync(m => m.IDBlog == id);
            if (cauhoi == null)
            {
                return NotFound();
            }
            return View(cauhoi);
        }
        // POST: User/CauHois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cauhoi = await _context.CauHois.FindAsync(id);
            _context.CauHois.Remove(cauhoi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool cauhoiExists(int id)
        {
            return _context.CauHois.Any(e => e.IDBlog == id);
        }
        public async Task<IActionResult> timkim(string searchString)
        {
            var doctors = from m in _context.CauHois
                          select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                doctors = doctors.Where(s => s.TieuDe.Contains(searchString));
            }            
            return View(await doctors.ToListAsync());
        }
     
        public async Task<IActionResult> Xoa(int id)
        {
            var duyettrangthai = _context.CauHois.Find(id);
            duyettrangthai.TrangThai = 3;

            _context.Update(duyettrangthai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
        }
        public async Task<IActionResult> hoangtac(int id)
        {
            var duyettrangthai = _context.CauHois.Find(id);
            duyettrangthai.TrangThai = 1;

            _context.Update(duyettrangthai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
