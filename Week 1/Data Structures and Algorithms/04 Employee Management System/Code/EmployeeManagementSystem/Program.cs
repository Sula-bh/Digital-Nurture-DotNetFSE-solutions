using EmployeeManagementSystem;

EmployeeManager manager = new EmployeeManager(10);

manager.AddEmployee(new Employee(101, "John", "Manager", 50000));

manager.AddEmployee(new Employee(102, "Alice", "Developer", 40000));

manager.AddEmployee(new Employee(103, "Bob", "Tester", 35000));

Console.WriteLine("Employees:");

manager.TraverseEmployees();

Console.WriteLine();

var employee = manager.SearchEmployee(102);

Console.WriteLine($"Found: {employee}");

Console.WriteLine();

manager.DeleteEmployee(102);

Console.WriteLine("After Deletion:");

manager.TraverseEmployees();
