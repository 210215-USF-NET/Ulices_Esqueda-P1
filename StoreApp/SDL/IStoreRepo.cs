using System;
using System.Collections.Generic;
using System.Text;
using SModels;

namespace SDL
{
    public interface IStoreRepo
    {
        void getOrderHistory(Customer customer);
        void getOrderHistory(Customer customer, int number);
        void getOrderHistory(Store store, int number);
        void getOrderHistory(Store store);
        void getLocationHistory(Customer customer);
        List<Store> getAllStores();
        void addVisistedStore(LocationVisited store);
        Customer addCustomer(Customer newCustomer);
        void addNewOrder();
        void addOrderItem(OrderItem newOrderItem);
        void addTrackOrderItem(TrackOrder newTrackOrder);
        void addProductToInventory(StoreInventory storeInventory);
        void addProductToDb(Product product);
        void getStoreInventory(Store store);
        void getCustomerByName(String customerName);
        void getAllProducts();
        void getAllStoreNames(Manager manager);
        void updateOrderTotal(Orders total);
        void updateStoreInventory(StoreInventory storeInventory);
        Store getStoreByName(String storeName);
        Product getProductByName(String productName);
        Product getStoreProductByName(String productName, Store store);
        Customer getCustomerByEmail(String email);
        Orders getMostRecentOrder();
        OrderItem getMostRecentOrderItem();
        Manager getManagerByFirstName(String managerName);
        bool checkStoreInventory(Store store);
        int getInventoryQuantity(Product product, Store store);
        StoreInventory getInventoryItem(Product product, Store store);
    }
}
