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

        public void addNewOrder()
        {
            throw new NotImplementedException();
        }

        public void addOrderItem(OrderItem newOrderItem)
        {
            throw new NotImplementedException();
        }

        public void addProductToDb(Product product)
        {
            throw new NotImplementedException();
        }

        public void addProductToInventory(StoreInventory storeInventory)
        {
            throw new NotImplementedException();
        }

        public void addTrackOrderItem(TrackOrder newTrackOrder)
        {
            throw new NotImplementedException();
        }

        public void addVisistedStore(LocationVisited store)
        {
            throw new NotImplementedException();
        }

        public bool checkStoreInventory(Store store)
        {
            throw new NotImplementedException();
        }

        public void getAllProducts()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int getInventoryQuantity(Product product, Store store)
        {
            throw new NotImplementedException();
        }

        public List<Store> getLocationHistory(Customer customer)
        {
            List<int> storeIDS = _context.LocationVisted.Where(cust => cust.ID == customer.ID).Select(store => store.Store.ID).ToList();
            List<Store> stores = new List<Store>();
            foreach (var value in storeIDS)
            {
                stores.Add(_context.Stores.Where(o => o.ID == value).FirstOrDefault());
            }
            return stores;
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
            /*var innerJoin = _context.Orders.Join(
                _context.TrackOrders,
                order => order.ID,
                track => track.Order.ID,
                (order, track) => new
                {
                    order.OrderDate,
                    order.OrderTotal
                }
                ).ToList();*/
            List<int> orderIDS = _context.TrackOrders.Where(cust => cust.ID == customer.ID).Select(order => order.Order.ID).ToList();
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

        public void getOrderHistory(Store store)
        {
            throw new NotImplementedException();
        }

        public Product getProductByName(string productName)
        {
            throw new NotImplementedException();
        }

        public Store getStoreByName(string storeName)
        {
            return _context.Stores.First(store => store.StoreName == storeName);
        }

        public void getStoreInventory(Store store)
        {
            throw new NotImplementedException();
        }

        public Product getStoreProductByName(string productName, Store store)
        {
            throw new NotImplementedException();
        }

        public void updateOrderTotal(Orders total)
        {
            throw new NotImplementedException();
        }

        public void updateStoreInventory(StoreInventory storeInventory)
        {
            throw new NotImplementedException();
        }
    }
}