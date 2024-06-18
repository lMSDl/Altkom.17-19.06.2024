using WPC.DesignPatterns.Structural.Bridge;
using WPC.DesignPrinciples;




Client.Execute();



static void ExecuteDesignPrinciples()
{
    var customerService = new CustomerService();
    var paymentService = new PaymentService();

    var customerId = 1;
    var customer = customerService.FindById(customerId);

    if (customer is null)
    {
        Console.WriteLine($"Customer {customerId} not exists");
        return;
    }

    var customerPaymentAccount = customer.PaymentAccount;
    paymentService.Fund(customerPaymentAccount, 500);
    if (paymentService.Charge(customerPaymentAccount, 100))
        Console.WriteLine($"Customer {customerId} charged. Actual balance: {customerPaymentAccount.Balance}");
    else
        Console.WriteLine($"Not enought founds on customer {customerId} acconut! Actual balance: {customerPaymentAccount.Balance}");
}

static void SOLID_LSP()
{
    int a = 4;
    int b = 9;

    var rectangle = CreateRectangle(a, b);
    Console.WriteLine($"{a} * {b} = {rectangle.Area}");


    WPC.SOLID.LSP_2.Rectangle CreateRectangle(int a, int b)
    {
        return new WPC.SOLID.LSP_2.Square { A = a, B = b };
    }
}