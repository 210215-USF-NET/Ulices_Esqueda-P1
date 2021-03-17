using SModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMVC.Models
{
    public class Mapper : IMapper
    {
        public RegisterCreateVM cast2RegisterCreateVM(Customer customer2bCasted)
        {
            return new RegisterCreateVM
            {
                CustomerFirstName = customer2bCasted.CustomerFirstName,
                CustomerLastName = customer2bCasted.CustomerLastName,
                Email = customer2bCasted.Email,
                CustomerPhoneNumber = customer2bCasted.CustomerPhoneNumber
            };
        }

        public Customer cast2Customer(RegisterCreateVM customer2bCasted)
        {
            return new Customer
            {
                CustomerFirstName = customer2bCasted.CustomerFirstName,
                CustomerLastName = customer2bCasted.CustomerLastName,
                Email = customer2bCasted.Email,
                CustomerPhoneNumber = customer2bCasted.CustomerPhoneNumber
            };
        }

        public Store cast2Store(StoreListVM store2bCasted)
        {
            return new Store
            {
                StoreName = store2bCasted.StoreName
            };
        }

        public StoreListVM cast2StoreListVM(Store store2bCasted)
        {
            if (store2bCasted == null) {
                return new StoreListVM
                {
                    StoreName = "The Crafty Minotaur"
                };
            }
            return new StoreListVM
            {
                StoreName = store2bCasted.StoreName
            };
        }

        public Customer cast2Customer(LoginCreateVM customer2bCasted)
        {
            return new Customer
            {
                Email = customer2bCasted.Email
            };
        }

        public LoginCreateVM cast2LoginCreateVM(Customer customer2bCasted)
        {
            return new LoginCreateVM
            {
                Email = customer2bCasted.Email
            };
        }

        public StoreInventory cast2StoreInventory(StoreInventoryVM store2bCasted)
        {
            return new StoreInventory
            {
                StoreID = store2bCasted.StoreID,
                ProductID = store2bCasted.ProductID,
                InventoryQuantity = store2bCasted.InventoryQuantity
            };
        }

        public StoreInventoryVM cast2StoreInventoryVM(StoreInventory store2bCasted)
        {
            return new StoreInventoryVM
            {
                StoreID = store2bCasted.StoreID,
                ProductID = store2bCasted.ProductID,
                InventoryQuantity = store2bCasted.InventoryQuantity
            };
        }
    }
}
