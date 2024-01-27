using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCompany.DpContext;
using ProjectCompany.Models;

namespace ProjectCompany.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ProjectController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: ProjectController
        public ActionResult Index()
        {
            List<Project> projects = _appDbContext.Projects.ToList();
            return View(projects);
        }

        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            return View(_appDbContext.Projects.Where(x => x.Pnumber == id).FirstOrDefault());
        }

        // GET: ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            try
            {
                _appDbContext.Add(project);
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_appDbContext.Projects.Where(x => x.Pnumber == id).FirstOrDefault());
        }

        // POST: ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Project project)
        {
            try
            {
                _appDbContext.Entry(project).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_appDbContext.Projects.Where(x => x.Pnumber == id).FirstOrDefault());
        }

        // POST: ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Project project)
        {
            try
            {
                var project1 = _appDbContext.Projects.Where(x => x.Pnumber == id).FirstOrDefault();
                //_appDbContext.Entry(department1).State = EntityState.Deleted;
                _appDbContext.Projects.Remove(project1);
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
