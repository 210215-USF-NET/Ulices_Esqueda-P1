using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBL;
using SModels;
using SMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View(_storeBL.getAllStores().Select(store => _mapper.cast2StoreListVM(store)).ToList());
        }

        // GET: StoreController/Details/5
        public ActionResult Details(string name)
        {
            return View(_mapper.cast2StoreListVM(_storeBL.getStoreByName(name)));
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
