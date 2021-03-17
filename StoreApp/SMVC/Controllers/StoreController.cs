using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBL;
using SModels;
using SMVC.Models;
using System.Collections.Generic;
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
            ViewBag.storeInventories = _storeBL.getStoreInventory(_store);
            ViewBag.products = _storeBL.getAllProducts();
            return View(_store);
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateStoreInventory(int id)
        {
            ViewBag.products = _storeBL.getAllProducts();
            ViewBag.StoreID = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStoreInventory(StoreInventoryVM inventoryVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _storeBL.addProductToInventory(_mapper.cast2StoreInventory(inventoryVM));
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
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
            ViewBag.products = _storeBL.getAllProducts();
            return View(_storeBL.getStoreByID(id));
        }

        // POST: StoreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StoreInventory inventory)
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