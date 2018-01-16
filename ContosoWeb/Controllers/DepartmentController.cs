using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Service;
using Contoso.Data;

namespace ContosoWeb.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService  _ids;
        public DepartmentController(IDepartmentService ids)
        {
            _ids = ids;
        }
        // GET: Department
        public ActionResult Index()
        {
            //ContosoDbContext dbContext = new ContosoDbContext();
            //DepartmentRepository dr = new DepartmentRepository(dbContext);
            //DepartmentService ds = new DepartmentService(dr);
            //var depts = ds.GetAll();
            var depts = _ids.GetAll();
            return View(depts);
        }

        // GET: Department/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
