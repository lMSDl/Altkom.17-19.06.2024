using WPC.DesignPrinciples;

var customerService = new CustomerService();
var paymentService = new PaymentService();

var customerId = 1;
var customer = customerService.FindById(customerId);
paymentService.Fund(customer, 500);
if (paymentService.Charge(customer, 100))
    Console.WriteLine($"Customer {customerId} charged. Actual balance: {customer.PaymentAccount.Balance}");
else
    Console.WriteLine($"Not enought founds on customer {customerId} acconut! Actual balance: {customer.PaymentAccount.Balance}");