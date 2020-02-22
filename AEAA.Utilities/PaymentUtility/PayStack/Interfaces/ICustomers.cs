using AEAA.Payment.Core.Paystack.Models.Customers;
using System.Threading.Tasks;

namespace AEAA.Payment.Core.Paystack.Interfaces
{
    public interface ICustomers
    {
        Task<CustomerCreationResponse> CreateCustomer(string email,string firstname =null,string lastname=null, string phone = null);

        Task<CustomerListResponse> ListCustomers();
        Task<CustomerCreationResponse> FetchCustomer(int id);
    }
}
