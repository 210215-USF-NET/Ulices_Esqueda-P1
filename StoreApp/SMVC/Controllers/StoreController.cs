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
        private Orders _order;

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

        public ActionResult SuccessfulPurchase()
        {
            Orders order = _storeBL.addNewOrder();
            HttpContext.Session.SetString("orderData", JsonSerializer.Serialize(order));
            return View();
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
        public ActionResult OrderHistoryOfLocation(int id)
        {
            Store store = _storeBL.getStoreByID(id);
            List<Orders> orders = _storeBL.getOrderHistory(store);
            return View(orders);
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
                    if (_storeBL.inventoryExists(inventoryVM.ProductID, inventoryVM.StoreID))
                    {
                        _product = _storeBL.getProductByID(inventoryVM.ProductID);
                        _store = _storeBL.getStoreByID(inventoryVM.StoreID);
                        int storeItemQuantity = _storeBL.getInventoryQuantity(_product, _store);
                        StoreInventory storeInventory = _storeBL.getInventoryItem(_product, _store);
                        storeInventory.InventoryQuantity = storeItemQuantity + inventoryVM.InventoryQuantity;
                        _storeBL.updateStoreInventory(storeInventory);
                    }
                    else
                    {
                        _storeBL.addProductToInventory(_mapper.cast2StoreInventory(inventoryVM));
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        public ActionResult AddQuantityToCart(int storeid, int prodId)
        {
            StoreInventoryVM storeInventoryVM = new StoreInventoryVM();
            storeInventoryVM.StoreID = storeid;
            storeInventoryVM.ProductID = prodId;
            return View(storeInventoryVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddQuantityToCart(StoreInventoryVM inventoryVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _product = _storeBL.getProductByID(inventoryVM.ProductID);
                    _order = JsonSerializer.Deserialize<Orders>(HttpContext.Session.GetString("orderData"));
                    _store = _storeBL.getStoreByID(inventoryVM.StoreID);

                    OrderItem newOrderItem = new OrderItem();
                    newOrderItem.ProductID = inventoryVM.ProductID;
                    newOrderItem.ProductQuantity = inventoryVM.InventoryQuantity;
                    newOrderItem = _storeBL.addOrderItem(newOrderItem);

                    _order.OrderTotal += _product.Price * newOrderItem.ProductQuantity;
                    HttpContext.Session.SetString("orderData", JsonSerializer.Serialize(_order));

                    if (HttpContext.Session.GetString("userData") != null)
                    {
                        TrackOrder track = new TrackOrder();
                        _customer = JsonSerializer.Deserialize<Customer>(HttpContext.Session.GetString("userData"));
                        track.CustomerID = _customer.ID;
                        track.OrderID = _order.ID;
                        track.OrderItemID = newOrderItem.ID;
                        track.StoreID = inventoryVM.StoreID;
                        _storeBL.addTrackOrderItem(track);
                    }
                    else
                    {
                        TrackOrder track = new TrackOrder();
                        track.CustomerID = 8;
                        track.OrderID = _order.ID;
                        track.OrderItemID = newOrderItem.ID;
                        track.StoreID = inventoryVM.StoreID;
                        _storeBL.addTrackOrderItem(track);
                    }
                    int storeItemQuantity = _storeBL.getInventoryQuantity(_product, _store);
                    StoreInventory storeInventory = _storeBL.getInventoryItem(_product, _store);
                    storeInventory.InventoryQuantity = storeItemQuantity - inventoryVM.InventoryQuantity;
                    _storeBL.updateStoreInventory(storeInventory);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        public ActionResult Cart()
        {
            _order = JsonSerializer.Deserialize<Orders>(HttpContext.Session.GetString("orderData"));
            List<OrderItem> cartItems = _storeBL.getOrderDetails(_order);
            ViewBag.products = _storeBL.getAllProducts();
            return View(cartItems);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cart(OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Orders order = JsonSerializer.Deserialize<Orders>(HttpContext.Session.GetString("orderData"));
                    _storeBL.updateOrderTotal(order);
                    return RedirectToAction(nameof(SuccessfulPurchase));
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