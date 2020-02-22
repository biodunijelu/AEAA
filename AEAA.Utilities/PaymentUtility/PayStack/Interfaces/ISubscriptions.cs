using AEAA.Payment.Core.Paystack.Models.Subscription;
using System.Threading.Tasks;

namespace AEAA.Payment.Core.Paystack.Interfaces
{
    public interface ISubscriptions
    {
        Task<SubscriptionModel> CreateSubscription(string customerEmail, string planCode, string authorization,string start_date);
    }
}
