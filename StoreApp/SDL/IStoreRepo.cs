using System;
using System.Collections.Generic;
using System.Text;
using SModels;

namespace SDL
{
    public interface IStoreRepo
    {
        List<Orders> getOrderHistory(Customer customer);
        void getOrderHistory(Customer customer, int number);
        void getOrderHistory(Store store, int number);
        List<Orders> getOrderHistory(Store store);
        List<Store> getLocationHistory(Customer customer);
        List<LocationVisited> getLocationHistory2(Customer customer);
        List<Store> getAllStores();
        void addVisistedStore(LocationVisited store);
        Customer addCustomer(Customer newCustomer);
        Orders addNewOrder();
        OrderItem addOrderItem(OrderItem newOrderItem);
        void addTrackOrderItem(TrackOrder newTrackOrder);
        void addProductToInventory(StoreInventory storeInventory);
        void addProductToDb(Product product);
        List<StoreInventory> getStoreInventory(Store store);
        void getCustomerByName(String customerName);
        List<Product> getAllProducts();
        void updateOrderTotal(Orders total);
        void updateStoreInventory(StoreInventory storeInventory);
        Store getStoreByName(String storeName);
        Product getProductByName(String productName);
        Product getStoreProductByName(String productName, Store store);
        Customer getCustomerByEmail(String email);
        Orders getMostRecentOrder();
        OrderItem getMostRecentOrderItem();
        bool checkStoreInventory(Store store);
        int getInventoryQuantity(Product product, Store store);
        StoreInventory getInventoryItem(Product product, Store store);
        Store getStoreByID(int id);
        Product getProductByID(int id);
        List<OrderItem> getOrderDetails(Orders order);
        bool inventoryExists(int productID, int storeID);
        Orders getOrderByID(int id);
    }
}
