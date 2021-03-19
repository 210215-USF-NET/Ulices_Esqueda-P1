using SDL;
using SModels;
using System;
using System.Collections.Generic;

namespace SBL
{
    public class StoreBL : IStoreBL
    {
        private IStoreRepo _repo;

        public StoreBL(IStoreRepo repo)
        {
            _repo = repo;
        }

        public List<Orders> getOrderHistory(Customer customer)
        {
            return _repo.getOrderHistory(customer);
        }

        public void getOrderHistory(Customer customer, int number)
        {
            _repo.getOrderHistory(customer, number);
        }

        public void getOrderHistory(Store store, int number)
        {
            _repo.getOrderHistory(store, number);
        }

        public List<Orders> getOrderHistory(Store store)
        {
            return _repo.getOrderHistory(store);
        }

        public List<Store> getLocationHistory(Customer customer)
        {
            return _repo.getLocationHistory(customer);
        }
        public List<LocationVisited> getLocationHistory2(Customer customer)
        {
            return _repo.getLocationHistory2(customer);
        }

        public List<Store> getAllStores()
        {
            return _repo.getAllStores();
        }

        public Store getStoreByName(String storeName)
        {
            return _repo.getStoreByName(storeName);
        }

        public Customer getCustomerByEmail(String email)
        {
            return _repo.getCustomerByEmail(email);
        }

        public Customer addCustomer(Customer newCustomer)
        {
            return _repo.addCustomer(newCustomer);
        }

        public void addVisistedStore(LocationVisited store)
        {
            _repo.addVisistedStore(store);
        }

        public Product getProductByName(string productName)
        {
            return _repo.getProductByName(productName);
        }

        public Orders addNewOrder()
        {
            return _repo.addNewOrder();
        }

        public OrderItem addOrderItem(OrderItem newOrderItem)
        {
            return _repo.addOrderItem(newOrderItem);
        }

        public void addTrackOrderItem(TrackOrder newTrackOrder)
        {
            _repo.addTrackOrderItem(newTrackOrder);
        }

        public Orders getMostRecentOrder()
        {
            return _repo.getMostRecentOrder();
        }

        public OrderItem getMostRecentOrderItem()
        {
            return _repo.getMostRecentOrderItem();
        }

        public List<StoreInventory> getStoreInventory(Store store)
        {
            return _repo.getStoreInventory(store);
        }

        /*public Manager getManagerByFirstName(String managerName)
        {
            return _repo.getManagerByFirstName(managerName);
        }*/

        public void getCustomerByName(string customerName)
        {
            _repo.getCustomerByName(customerName);
        }

        public List<Product> getAllProducts()
        {
            return _repo.getAllProducts();
        }

        public void addProductToInventory(StoreInventory storeInventory)
        {
            _repo.addProductToInventory(storeInventory);
        }

        public void addProductToDb(Product product)
        {
            _repo.addProductToDb(product);
        }

        /*public void getAllStoreNames(Manager manager)
        {
            _repo.getAllStoreNames(manager);
        }*/

        public void updateOrderTotal(Orders total)
        {
            _repo.updateOrderTotal(total);
        }

        public Product getStoreProductByName(string productName, Store store)
        {
            return _repo.getStoreProductByName(productName, store);
        }

        public bool checkStoreInventory(Store store)
        {
            return _repo.checkStoreInventory(store);
        }

        public int getInventoryQuantity(Product product, Store store)
        {
            return _repo.getInventoryQuantity(product, store);
        }

        public void updateStoreInventory(StoreInventory storeInventory)
        {
            _repo.updateStoreInventory(storeInventory);
        }

        public StoreInventory getInventoryItem(Product product, Store store)
        {
            return _repo.getInventoryItem(product, store);
        }
        public Store getStoreByID(int id)
        {
            return _repo.getStoreByID(id);
        }
        public List<OrderItem> getOrderDetails(Orders order)
        {
            return _repo.getOrderDetails(order);
        }

        public Product getProductByID(int id)
        {
            return _repo.getProductByID(id);
        }

        public bool inventoryExists(int productID, int storeID)
        {
            return _repo.inventoryExists(productID, storeID);
        }

        public Orders getOrderByID(int id)
        {
            return _repo.getOrderByID(id);
        }
    }
}