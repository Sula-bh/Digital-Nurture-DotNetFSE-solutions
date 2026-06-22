using DependencyInjectionExample.Repositories;
using DependencyInjectionExample.Services;

ICustomerRepository repository = new CustomerRepositoryImpl();

CustomerService service = new CustomerService(repository);

var customer = service.GetCustomer(101);

Console.WriteLine($"ID: {customer.Id}");

Console.WriteLine($"Name: {customer.Name}");
