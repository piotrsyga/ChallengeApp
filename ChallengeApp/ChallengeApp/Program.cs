    Employee employee1 = new Employee();
    Employee employee2 = new Employee("Agnieszka", "Kowalska");
    Employee employee3 = new Employee("Zuzia", "Michalczyk", "23");

employee1.AddScore(5); employee1.AddScore(4); employee1.AddScore(2); employee1.AddScore(6); employee1.AddScore(3);
employee2.AddScore(5); employee2.AddScore(4); employee2.AddScore(6); employee2.AddScore(5); employee2.AddScore(8);
employee3.AddScore(7); employee3.AddScore(7); employee3.AddScore(9); employee3.AddScore(5); employee3.AddScore(4);

Console.WriteLine("Zwycięzcą zostaje");
Console.WriteLine(nameof(employee3));

