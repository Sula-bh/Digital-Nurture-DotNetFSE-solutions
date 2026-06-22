namespace EmployeeManagementSystem;

public class EmployeeManager
{
    private Employee[] employees;

    private int count;

    public EmployeeManager(int size)
    {
        employees = new Employee[size];
        count = 0;
    }

    public void AddEmployee(Employee employee)
    {
        if (count < employees.Length)
        {
            employees[count] = employee;
            count++;
        }
        else
        {
            Console.WriteLine("Array is full.");
        }
    }

    public Employee? SearchEmployee(int employeeId)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == employeeId)
            {
                return employees[i];
            }
        }

        return null;
    }

    public void TraverseEmployees()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }

    public void DeleteEmployee(int employeeId)
    {
        int index = -1;

        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == employeeId)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        for (int i = index; i < count - 1; i++)
        {
            employees[i] = employees[i + 1];
        }

        employees[count - 1] = null!;
        count--;
    }
}