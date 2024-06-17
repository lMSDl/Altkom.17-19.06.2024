

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool Charge(int id, float amount)
        {
            var account = FindById(id);
            return account?.Charge(amount) ?? false;
        }
        public void Fund(int id, float amount)
        {
            var account = FindById(id);
            account?.Fund(amount);
        }

        private PaymentAccount? FindById(int id)
        {
            return PaymentAccounts.Where(x => !x.IsDeleted).SingleOrDefault(x => x.Id == id);
        }

    }
}
