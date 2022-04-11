// See https://aka.ms/new-console-template for more information
using Exercise2;

Student[] students = new Student[] {new Student(10,"Mark","Johnson"),new Student(36,"Hunter","Junior"),new Student(67,"Philipa","Featherington"),new Student(80,"Grace","John"),new Student(45,"Mark","Anthony"),new Student(34,"Ruby","Congen"),new Student(24,"Carlo","Reynolds"),new Student(70,"Julia","Quinn"),new Student(68,"Lisa","Kleypas"),new Student(85,"Iruoma","Onyia")};
Array.Sort<Student>(students);
Array.Reverse(students);
Console.WriteLine("STUDENTS");
foreach (var student in students)
{
    Console.WriteLine($"{student.FirstName} scored {student.Mark} on the test");
}
Worker[] workers = new Worker[] { new Worker(1000,5, "Mark", "Johnson"), new Worker(3600,8, "Hunter", "Junior"), new Worker(6700,10, "Philipa", "Featherington"), new Worker(8000,13, "Grace", "John"), new Worker(4500,6, "Mark", "Anthony"), new Worker(3400,6, "Ruby", "Congen"), new Worker(2400,4, "Carlo", "Reynolds"), new Worker(7000,7, "Julia", "Quinn"), new Worker(6800,7, "Lisa", "Kleypas"), new Worker(85000,14, "Iruoma", "Onyia") };
Array.Sort(workers);
Console.WriteLine();
Console.WriteLine("WORKERS");
foreach (var worker in workers)
{
    Console.WriteLine($"{worker.FirstName} earns {worker.Wage}");
}

