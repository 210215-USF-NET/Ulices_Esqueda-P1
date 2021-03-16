using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SModels;

namespace SMVC.Models
{
    public interface IMapper
    {
        Store cast2Store(StoreListVM store2bCasted);
        StoreListVM cast2StoreListVM(Store store2bCasted);
        Customer cast2Customer(RegisterCreateVM customer2bCasted);
        RegisterCreateVM cast2RegisterCreateVM(Customer customer2bCasted);
        Customer cast2Customer(LoginCreateVM customer2bCasted);
        LoginCreateVM cast2LoginCreateVM(Customer customer2bCasted);

    }
}
