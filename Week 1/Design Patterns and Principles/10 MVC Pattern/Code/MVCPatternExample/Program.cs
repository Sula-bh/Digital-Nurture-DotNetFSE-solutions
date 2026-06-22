using MVCPatternExample.Controllers;
using MVCPatternExample.Models;
using MVCPatternExample.Views;

Student model = new Student("Alice", 101, "A");

StudentView view = new StudentView();

StudentController controller = new StudentController(model, view);

controller.UpdateView();

Console.WriteLine();

controller.SetStudentName("Bob");
controller.SetStudentGrade("A+");

controller.UpdateView();
