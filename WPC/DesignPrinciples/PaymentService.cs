

namespace WPC.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeletePaymentAccount(PaymentAccount account)
        {
            return PaymentAccounts.Remove(account);
        }

        public PaymentAccount FindByAllowedDebit(float debit)
        {
            return PaymentAccounts.SingleOrDefault(x => x.AllowedDebit == debit);
        }

        public bool Charge(int id, float amount)
        {
            var account = FindById(id);
            if (account == null)
                return false;

            if (GetBalance(id) + account.AllowedDebit < amount)
                return false;

            account.Outcome += amount;
            return true;
        }

        private PaymentAccount? FindById(int id)
        {
            return PaymentAccounts.Where(x => !x.IsDeleted).SingleOrDefault(x => x.Id == id);
        }

        public void Fund(int id, float amount)
        {
            var account = FindById(id);
            if (account == null)
                return;
            account.Income += amount;
        }

        public float? GetBalance(int id)
        {
            var account = FindById(id);
            return account?.Income - account?.Outcome;
        }
    }
}
