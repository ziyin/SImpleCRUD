using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SImpleCRUD.Data;
using SImpleCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace SImpleCRUD.Controllers
{
    public class FunctionController : Controller
    {
        private readonly SImpleCRUDContext _context;

        public FunctionController(SImpleCRUDContext context)
        {
            _context = context;
        }

        #region 新增

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert([Bind("ID,Address,Owner,Size,RoomNum,HallNum,BathNum,year,type,floor,price,remark,UpdateTime")] House house)
        {
            if (ModelState.IsValid)
            {
                if (Check_(house))
                {
                    house.UpdateTime = DateTime.Now;
                    TempData["msgbox"] = "新增成功";
                    _context.Add(house);
                    await _context.SaveChangesAsync();
                }
                else
                    TempData["msgbox"] = "該房屋已建過檔";

            }

            return View();
        }

        private bool Check_(House house)
        {
            var db_Info = _context.House.FirstOrDefault(m => m.Address == house.Address && m.BathNum == house.BathNum && m.Owner == house.Owner && m.Size == house.Size && m.HallNum == house.HallNum && m.RoomNum == house.RoomNum && m.year == house.year && m.floor == house.floor && m.price == house.price);

            if (db_Info != null)
            {
                return false;
            }

            return true;
        }

        #endregion

        #region 修改

        public async Task<IActionResult> Update()
        {
            return View(await _context.House.OrderByDescending(s => s.UpdateTime).ToListAsync());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var house = await _context.House.FindAsync(id);
            return View(house);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, [Bind("ID,Address,Owner,Size,RoomNum,HallNum,BathNum,year,type,floor,price,remark,UpdateTime")] House house)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    house.UpdateTime = DateTime.Now;
                    _context.Update(house);
                     await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                }
            }
            return RedirectToAction(nameof(Update));
        }

        #endregion

        #region 刪除

        public async Task<IActionResult> Delete()
        {
            return View(await _context.House.ToListAsync());
        }

        public async Task<IActionResult> del(int? id)
        {
            var house = await _context.House.FindAsync(id);
            return View(house);
        }

        [HttpPost, ActionName("del")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var house = await _context.House.FindAsync(id);
            _context.House.Remove(house);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Delete));
        }

        #endregion

        #region 清單

        public async Task<IActionResult> List()
        {
            return View(await _context.House.ToListAsync());
        }

        public IActionResult ExportExcell()
        {
            var builder = new StringBuilder();
            builder.AppendLine("房屋種類,房間數,客廳數,衛浴數,樓層,坪數,屋齡(年),地址,屋主,價格(萬),更新時間");
            foreach (var item in _context.House)
            {
                builder.AppendLine($"{item.type},{item.RoomNum},{item.HallNum},{item.BathNum},{item.floor},{item.Size},{item.year},{item.Address},{item.Owner},{item.price},{item.UpdateTime}");
            }
            return File(CodePagesEncodingProvider.Instance.GetEncoding("Big5").GetBytes(builder.ToString()), "text/csv", "house.csv");
        }

        #endregion
    }
}
