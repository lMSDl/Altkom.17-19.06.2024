using WPC.DesignPrinciples;

var service = new Class2();

var customerId = 1;

service.Func2(customerId, 500);
if (service.Func1(customerId, 100))
    Console.WriteLine($"Customer {customerId} charged. Actual balance: {service.GetBalance(customerId)}");
else
    Console.WriteLine($"Not enought founds on customer {customerId} acconut! Actual balance: {service.GetBalance(customerId)}");