using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SBL;
using SModels;
using SMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Controllers
{
    public class RegisterController : Controller
    {
        private IStoreBL _storeBL;
        private IMapper _mapper;
        private Customer _customer;
        private readonly ILogger<RegisterController> _logger;
        public RegisterController(IStoreBL storeBL, IMapper mapper, ILogger<RegisterController> logger)
        {
            _storeBL = storeBL;
            _mapper = mapper;
            _logger = logger;
        }
        // GET: RegisterController
        public ActionResult Index()
        {
            return View("../Home/Index");
        }

        // GET: RegisterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterController/Create
        public ActionResult Create()
        {
            _logger.LogInformation("User is Registered");
            return View();
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterCreateVM customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _customer = _storeBL.addCustomer(_mapper.cast2Customer(customer));
                    ViewData["User"] = _customer;
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: RegisterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
