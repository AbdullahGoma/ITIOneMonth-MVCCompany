using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;
using ProjectCompany.Models;

namespace ProjectCompany.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            List<Department> departments = _appDbContext.Departments.ToList();
            return View(departments);
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.Departments.Where(x => x.Dnumber == id).FirstOrDefault());
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            try
            {
                _appDbContext.Departments.Add(department);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.Departments.Where(x => x.Dnumber == id).FirstOrDefault());
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                _appDbContext.Entry(department).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.Departments.Where(x => x.Dnumber == id).FirstOrDefault());
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Department department)
        {
            try
            {
                var department1 = _appDbContext.Departments.Where(x => x.Dnumber == id).FirstOrDefault();
                //_appDbContext.Entry(department1).State = EntityState.Deleted;
                _appDbContext.Departments.Remove(department1);
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
