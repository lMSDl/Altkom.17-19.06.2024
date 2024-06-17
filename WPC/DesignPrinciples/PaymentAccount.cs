
namespace WPC.DesignPrinciples
{
    public class PaymentAccount
    {
        public PaymentAccount(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public float Income { get; set; }
        public float Outcome { get; set; }
        public float AllowedDebit { get; set; }
        public bool IsDeleted { get; }

        public bool Charge(float amount)
        {
            if (Balance + AllowedDebit < amount)
                return false;

            Outcome += amount;
            return true;
        }

        public void Fund(float amount)
        {
            account.Income += amount;
        }


        private float Balance => Income - Outcome;
    }
}
