using SModels;
using System;
using System.Collections.Generic;

namespace SBL
{
    public interface IStoreBL
    {
        List<Orders> getOrderHistory(Customer customer);

        void getOrderHistory(Customer customer, int number);

        void getOrderHistory(Store store, int number);

        List<Orders> getOrderHistory(Store store);

        List<Store> getLocationHistory(Customer customer);

        List<LocationVisited> getLocationHistory2(Customer customer);

        List<Store> getAllStores();

        //void getAllStoreNames(Manager manager);

        Customer addCustomer(Customer newCustomer);

        void addVisistedStore(LocationVisited store);

        Orders addNewOrder();

        OrderItem addOrderItem(OrderItem newOrderItem);

        void addTrackOrderItem(TrackOrder newTrackOrder);

        void addProductToInventory(StoreInventory storeInventory);

        void addProductToDb(Product product);

        List<StoreInventory> getStoreInventory(Store store);

        void getCustomerByName(String customerName);
        Store getStoreByID(int id);

        List<Product> getAllProducts();

        void updateOrderTotal(Orders total);

        void updateStoreInventory(StoreInventory storeInventory);

        StoreInventory getInventoryItem(Product product, Store store);

        Store getStoreByName(String storeName);

        Customer getCustomerByEmail(String email);

        Product getProductByName(String productName);
        Orders getOrderByID(int id);
        Product getStoreProductByName(String productName, Store store);

        Orders getMostRecentOrder();

        OrderItem getMostRecentOrderItem();

        //Manager getManagerByFirstName(String managerName);

        bool checkStoreInventory(Store store);

        int getInventoryQuantity(Product product, Store store);
        List<OrderItem> getOrderDetails(Orders order);
        Product getProductByID(int id);
        bool inventoryExists(int productID, int storeID);
    }
}