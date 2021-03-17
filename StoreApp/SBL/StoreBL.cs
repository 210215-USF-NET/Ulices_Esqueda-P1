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

        public void getOrderHistory(Store store)
        {
            _repo.getOrderHistory(store);
        }

        public void getLocationHistory(Customer customer)
        {
            _repo.getLocationHistory(customer);
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

        public void addNewOrder()
        {
            _repo.addNewOrder();
        }

        public void addOrderItem(OrderItem newOrderItem)
        {
            _repo.addOrderItem(newOrderItem);
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

        public void getStoreInventory(Store store)
        {
            _repo.getStoreInventory(store);
        }

        /*public Manager getManagerByFirstName(String managerName)
        {
            return _repo.getManagerByFirstName(managerName);
        }*/

        public void getCustomerByName(string customerName)
        {
            _repo.getCustomerByName(customerName);
        }

        public void getAllProducts()
        {
            _repo.getAllProducts();
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
    }
}