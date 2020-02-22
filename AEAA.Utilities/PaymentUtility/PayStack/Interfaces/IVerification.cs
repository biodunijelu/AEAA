using AEAA.Payment.Core.Paystack.Models.Verification;
using System.Threading.Tasks;

namespace Paystack.NetAEAA.Payment.Core.Paystack.Interfaces
{
    public interface IVerification
    {
        Task<BVNVerificationResponseModel> ResolveBVN(string bvn);
    }
}
