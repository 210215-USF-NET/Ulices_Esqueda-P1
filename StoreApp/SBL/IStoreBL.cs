using SModels;
using System;
using System.Collections.Generic;

namespace SBL
{
    public interface IStoreBL
    {
        void getOrderHistory(Customer customer);

        void getOrderHistory(Customer customer, int number);

        void getOrderHistory(Store store, int number);

        void getOrderHistory(Store store);

        void getLocationHistory(Customer customer);

        List<Store> getAllStores();

        void getAllStoreNames(Manager manager);

        Customer addCustomer(Customer newCustomer);

        void addVisistedStore(LocationVisited store);

        void addNewOrder();

        void addOrderItem(OrderItem newOrderItem);

        void addTrackOrderItem(TrackOrder newTrackOrder);

        void addProductToInventory(StoreInventory storeInventory);

        void addProductToDb(Product product);

        void getStoreInventory(Store store);

        void getCustomerByName(String customerName);

        void getAllProducts();

        void updateOrderTotal(Orders total);

        void updateStoreInventory(StoreInventory storeInventory);

        StoreInventory getInventoryItem(Product product, Store store);

        Store getStoreByName(String storeName);

        Customer getCustomerByEmail(String email);

        Product getProductByName(String productName);

        Product getStoreProductByName(String productName, Store store);

        Orders getMostRecentOrder();

        OrderItem getMostRecentOrderItem();

        Manager getManagerByFirstName(String managerName);

        bool checkStoreInventory(Store store);

        int getInventoryQuantity(Product product, Store store);
    }
}