using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;
using ProjectCompany.Models;

namespace ProjectCompany.Controllers
{
    public class DependentController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public DependentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: DependentController
        public ActionResult Index()
        {
            List<Dependent> dependents = _appDbContext.Dependents.ToList();
            return View(dependents);
        }

        // GET: DependentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.Dependents.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: DependentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DependentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dependent dependent)
        {
            _appDbContext.Dependents.Add(dependent);
            _appDbContext.SaveChanges();
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DependentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.Dependents.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: DependentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Dependent dependent)
        {
            try
            {
                _appDbContext.Entry(dependent).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DependentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.Dependents.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: DependentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Dependent dependent)
        {
            try
            {
                var dependent1 = _appDbContext.Dependents.Where(x => x.Id == id).FirstOrDefault();
                //_appDbContext.Entry(department1).State = EntityState.Deleted;
                _appDbContext.Dependents.Remove(dependent1);
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
