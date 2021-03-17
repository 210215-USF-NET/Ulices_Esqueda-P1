using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SBL;
using SModels;
using SMVC.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace SMVC.Controllers
{
    public class LoginController : Controller
    {
        private IStoreBL _storeBL;
        private IMapper _mapper;
        private Customer _customer;
        private readonly ILogger<LoginController> _logger;

        public LoginController(IStoreBL store, IMapper mapper, ILogger<LoginController> logger)
        {
            _storeBL = store;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: LoginController
        public ActionResult Index()
        {
            return View("../Home/Index");
        }

        public ActionResult Logout()
        {
            return View();
        }
        public ActionResult UserSettings()
        {
            return View();
        }
        public ActionResult UserInformation()
        {
            return View();
        }
        public ActionResult OrderHistory()
        {
            _customer = JsonSerializer.Deserialize<Customer>(HttpContext.Session.GetString("userData"));
            List<Orders> orders = _storeBL.getOrderHistory(_customer);
            return View(orders);
        }
        public ActionResult LocationHistory()
        {
            _customer = JsonSerializer.Deserialize<Customer>(HttpContext.Session.GetString("userData"));
            List<Store> storesVisited = _storeBL.getLocationHistory(_customer);
            return View(storesVisited);
        }
        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LoginCreateVM customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _logger.LogInformation("User is logged in");
                    _customer = _storeBL.getCustomerByEmail(_mapper.cast2Customer(customer).Email);
                    HttpContext.Session.SetString("userData", JsonSerializer.Serialize(_customer));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

            return View();
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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