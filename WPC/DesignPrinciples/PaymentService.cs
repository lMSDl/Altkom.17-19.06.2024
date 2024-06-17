

using System.Security.Principal;

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        public bool Charge(PaymentAccount account, float amount)
        {
            return account.Charge(amount);
        }

        public void Fund(PaymentAccount account, float amount)
        {
            account.Fund(amount);
        }
    }
}
