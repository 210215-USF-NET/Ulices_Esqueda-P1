using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBL;
using SModels;
using SMVC.Models;
using System.Text.Json;

namespace SMVC.Controllers
{
    public class StoreController : Controller
    {
        private IStoreBL _storeBL;
        private IMapper _mapper;
        private Customer _customer;
        private Store _store;
        private Product _product;

        public StoreController(IStoreBL storeBL, IMapper mapper)
        {
            _storeBL = storeBL;
            _mapper = mapper;
        }

        // GET: StoreController
        public ActionResult Index()
        {
            return View(_storeBL.getAllStores());
        }

        // GET: StoreController/Details/StoreName={storename}
        public ActionResult Details(string StoreName)
        {
            _store = _storeBL.getStoreByName(StoreName);
            ViewBag.Store = _store;
            if (HttpContext.Session.GetString("userData") != null)
            {
                _customer = JsonSerializer.Deserialize<Customer>(HttpContext.Session.GetString("userData"));
                LocationVisited store = new LocationVisited();
                store.CustomerID = _customer.ID;
                store.StoreID = _store.ID;
                _storeBL.addVisistedStore(store);
            }
            return View(_store);
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: StoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
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

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
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