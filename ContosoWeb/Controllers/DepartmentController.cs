using Contoso.Data;
using Contoso.Model;
using Contoso.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoWeb.Controllers
{
    public class DepartmentController : Controller
    {
        private ContosoContext contoso = new ContosoContext();
        private readonly IDepartmentService _iDepartmentService;
        public DepartmentController(IDepartmentService iDepartmentService)
        {
            _iDepartmentService = iDepartmentService;
        }
        // GET: Department
        public ActionResult Index()
        {
            //ContosoContext cc = new ContosoContext();
            //DepartmentRepository ir = new DepartmentRepository(cc);
            //DepartmentService instructorService = new DepartmentService(ir);
            //var department = instructorService.GetAll();
            //-----------------------------------------------------//
            var departments = contoso.Departments.Include("Courses").ToList();
            //var departments = _iDepartmentService.GetAll();
            return View(departments);
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
        public ActionResult Create(Department dep)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _iDepartmentService.AddDepartment(dep);
                }

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
