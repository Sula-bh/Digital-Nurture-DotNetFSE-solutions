using TaskManagementSystem;

TaskLinkedList tasks = new TaskLinkedList();

tasks.AddTask(new TaskItem(101, "Design UI", "Pending"));

tasks.AddTask(new TaskItem(102, "Develop API", "In Progress"));

tasks.AddTask(new TaskItem(103, "Testing", "Pending"));

Console.WriteLine("Tasks:");

tasks.TraverseTasks();

Console.WriteLine();

var task = tasks.SearchTask(102);

Console.WriteLine($"Found: {task}");

Console.WriteLine();

tasks.DeleteTask(102);

Console.WriteLine("After Deletion:");

tasks.TraverseTasks();
