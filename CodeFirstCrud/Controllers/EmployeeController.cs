using System.Collections.Generic;
using AutoMapper;
using CodeFirstCrud.DataAccess;
using CodeFirstCrud.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstCrud.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        #region Index Action
        public IActionResult Index()
        {
            ICollection<EmployeeViewModel> model = _mapper.Map<ICollection<EmployeeViewModel>>(_unitofWork.EmployeeRepository.GetAll());
            return View(model);
        }
        #endregion

        #region Details Action
        public IActionResult Details(int id)
        {
            EmployeeViewModel model = _mapper.Map<EmployeeViewModel>(_unitofWork.EmployeeRepository.Get(id));
            return View(model);
        }
        #endregion

        #region Create Action
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                _unitofWork.EmployeeRepository.Create(_mapper.Map<Employee>(employee));
                _unitofWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Delate Action
        [HttpGet]
        [ActionName("Delete")]
        public IActionResult DeleteGet(int id)
        {
            EmployeeViewModel model = _mapper.Map<EmployeeViewModel>(_unitofWork.EmployeeRepository.Get(id));
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _unitofWork.EmployeeRepository.Delete(id);
            _unitofWork.SaveChanges();

            return RedirectToAction("Index");
        }
        #endregion

        #region Update Action
        [HttpGet]
        public IActionResult Update(int id)
        {
            UpdateEmployeeviewModel model = new UpdateEmployeeviewModel
            {
                Employee = _mapper.Map<EmployeeViewModel>(_unitofWork.EmployeeRepository.Get(id)),
                Departments = _mapper.Map<List<DepartmentViewModel>>(_unitofWork.DepartmentRepository.GetAll())
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                Employee emp = _mapper.Map<Employee>(employee);

                _unitofWork.EmployeeRepository.Update(emp);
                _unitofWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion
    }
}