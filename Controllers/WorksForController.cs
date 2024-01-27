using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;
using ProjectCompany.Models;

namespace ProjectCompany.Controllers
{
    public class WorksForController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public WorksForController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: WorksForController
        public ActionResult Index()
        {
            List<WorksFor> worksFors = _appDbContext.worksFors.ToList();
            return View();
        }

        // GET: WorksForController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.worksFors.Where(x => x.EmployeeId == id).FirstOrDefault());
        }

        // GET: WorksForController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorksForController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorksFor worksFor)
        {
            try
            {
                _appDbContext.Add(worksFor);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorksForController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.worksFors.Where(x => x.EmployeeId == id).FirstOrDefault());
        }

        // POST: WorksForController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorksFor worksFor)
        {
            try
            {
                _appDbContext.Entry(worksFor).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorksForController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.worksFors.Where(x => x.EmployeeId == id).FirstOrDefault());
        }

        // POST: WorksForController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WorksFor worksFor)
        {
            try
            {
                var worksFor1 = _appDbContext.worksFors.Where(x => x.EmployeeId == id).FirstOrDefault();
                //_appDbContext.Entry(department1).State = EntityState.Deleted;
                _appDbContext.worksFors.Remove(worksFor1);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
