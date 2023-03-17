    Employee employee1 = new Employee();
    Employee employee2 = new Employee("Agnieszka", "Kowalska");
    Employee employee3 = new Employee("Zuzia", "Michalczyk", "23");

    employee1.AddScore(5); employee1.AddScore(4); employee1.AddScore(2); employee1.AddScore(6); employee1.AddScore(3);
employee2.AddScore(5); employee2.AddScore(4); employee2.AddScore(6); employee2.AddScore(5); employee2.AddScore(8);
employee3.AddScore(7); employee3.AddScore(7); employee3.AddScore(9); employee3.AddScore(5); employee3.AddScore(4);
var result = employee3.Result;

    Console.WriteLine(result);

if (result<25)
    {
    Console.WriteLine("Jestem Adam Nowak, mam, 22 lata i 20 pkt.");
}
else if (result < 35)
{
    Console.WriteLine("Jestem Zuzia Michalczyk, mam 23 lata i 32 pkt.");
}
if (result < 30)
{
    Console.WriteLine("Jestem Agnieszka Kowalska, mam 25 lat i 28 pkt. ");
}
else if (result > 30)
{
    Console.WriteLine("Gratulujemy zwycięstwa, Pani Zuzannie Michalczyk");
}

