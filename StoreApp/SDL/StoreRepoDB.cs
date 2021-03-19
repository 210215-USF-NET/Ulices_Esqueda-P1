using SModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDL
{
    public class StoreRepoDB : IStoreRepo
    {
        private readonly StoreDBContext _context;

        public StoreRepoDB(StoreDBContext context)
        {
            _context = context;
        }

        public Customer addCustomer(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            return newCustomer;
        }

        public Orders addNewOrder()
        {
            Orders order = new Orders();
            order.OrderDate = DateTime.Now;
            order.OrderTotal = 0;
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public OrderItem addOrderItem(OrderItem newOrderItem)
        {
            _context.OrderItems.Add(newOrderItem);
            _context.SaveChanges();
            return newOrderItem;
        }

        public void addProductToDb(Product product)
        {
            throw new NotImplementedException();
        }

        public void addProductToInventory(StoreInventory storeInventory)
        {
            _context.StoreInventories.Add(storeInventory);
            _context.SaveChanges();
        }

        public void addTrackOrderItem(TrackOrder newTrackOrder)
        {
            _context.TrackOrders.Add(newTrackOrder);
            _context.SaveChanges();
        }

        public void addVisistedStore(LocationVisited store)
        {
            _context.LocationVisted.Add(store);
            _context.SaveChanges();
        }

        public bool checkStoreInventory(Store store)
        {
            throw new NotImplementedException();
        }

        public List<Product> getAllProducts()
        {
            return _context.Products.Select(c => c).ToList();
        }

        public List<Store> getAllStores()
        {
            return _context.Stores.Select(Store => Store).ToList();
        }

        /*public void getAllStoreNames(Manager manager)
        {
            throw new NotImplementedException();
        }*/

        public Customer getCustomerByEmail(string email)
        {
            return _context.Customers.FirstOrDefault(cust => cust.Email == email);
        }

        public void getCustomerByName(string customerName)
        {
            throw new NotImplementedException();
        }

        public StoreInventory getInventoryItem(Product product, Store store)
        {
            return _context.StoreInventories.Where(p => (p.ProductID == product.ID) && (p.StoreID == store.ID)).FirstOrDefault();
        }

        public int getInventoryQuantity(Product product, Store store)
        {
            StoreInventory quant = _context.StoreInventories.Where(p => (p.ProductID == product.ID) && (p.StoreID == store.ID)).FirstOrDefault();
            return quant.InventoryQuantity;
        }

        public List<Store> getLocationHistory(Customer customer)
        {
            List<int> storeIDS = _context.LocationVisted.Where(c => c.CustomerID == customer.ID).Select(s => s.StoreID).ToList();
            List<Store> stores = new List<Store>();
            foreach (var item in storeIDS)
            {
                stores.Add(_context.Stores.Where(o => o.ID == item).FirstOrDefault());
            }
            return stores;
        }


        public Store getStoreByID(int id)
        {
            return _context.Stores.First(s => s.ID == id);
        }

        /*public Manager getManagerByFirstName(string managerName)
        {
            throw new NotImplementedException();
        }*/

        public Orders getMostRecentOrder()
        {
            throw new NotImplementedException();
        }

        public OrderItem getMostRecentOrderItem()
        {
            throw new NotImplementedException();
        }

        public List<Orders> getOrderHistory(Customer customer)
        {
            List<int> orderIDS = _context.TrackOrders.Where(cust => cust.CustomerID == customer.ID).Select(order => order.OrderID).Distinct().ToList();
            List<Orders> orders = new List<Orders>();
            foreach (var value in orderIDS)
            {
                orders.Add(_context.Orders.Where(o => o.ID == value).FirstOrDefault());
            }
            return orders;
        }

        public void getOrderHistory(Customer customer, int number)
        {
            throw new NotImplementedException();
        }

        public void getOrderHistory(Store store, int number)
        {
            throw new NotImplementedException();
        }

        public List<Orders> getOrderHistory(Store store)
        {
            List<int> orderIDS = _context.TrackOrders.Where(cust => cust.StoreID == store.ID).Select(order => order.OrderID).Distinct().ToList();
            List<Orders> orders = new List<Orders>();
            foreach (var value in orderIDS)
            {
                orders.Add(_context.Orders.Where(o => o.ID == value).FirstOrDefault());
            }
            return orders;
        }

        public Product getProductByName(string productName)
        {
            throw new NotImplementedException();
        }

        public Store getStoreByName(string storeName)
        {
            return _context.Stores.First(store => store.StoreName == storeName);
        }

        public List<StoreInventory> getStoreInventory(Store store)
        {
            return _context.StoreInventories.Where(s => s.StoreID == store.ID).ToList();
        }

        public Product getStoreProductByName(string productName, Store store)
        {
            throw new NotImplementedException();
        }

        public void updateOrderTotal(Orders total)
        {
            total.OrderDate = DateTime.Now;
            Orders oldOrder = _context.Orders.Find(total.ID);
            _context.Entry(oldOrder).CurrentValues.SetValues(total);
            _context.SaveChanges();
        }

        public void updateStoreInventory(StoreInventory storeInventory)
        {
            StoreInventory oldInventory = _context.StoreInventories.Find(storeInventory.ID);
            _context.Entry(oldInventory).CurrentValues.SetValues(storeInventory);
            _context.SaveChanges();
        }

        public List<LocationVisited> getLocationHistory2(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Product getProductByID(int id)
        {
            return _context.Products.First(s => s.ID == id);
        }

        public List<OrderItem> getOrderDetails(Orders order)
        {
            List<int> orderIDS = _context.TrackOrders.Where(o => o.OrderID == order.ID).Select(ot => ot.OrderItemID).ToList();
            List<OrderItem> orderItem = new List<OrderItem>();
            foreach (var value in orderIDS)
            {
                orderItem.Add(_context.OrderItems.Where(o => o.ID == value).FirstOrDefault());
            }
            return orderItem;
        }

        public bool inventoryExists(int productID, int storeID)
        {
            if (_context.StoreInventories.Where(p => (p.ProductID == productID) && (p.StoreID == storeID)).FirstOrDefault() == null)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public Orders getOrderByID(int id)
        {
            return _context.Orders.First(s => s.ID == id);
        }
    }
}