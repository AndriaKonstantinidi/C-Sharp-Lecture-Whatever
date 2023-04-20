////inheritance
//public class Employee
//{
//    public string name { get; set; }
//    public int age { get; set; }
//    public double salary { get; set; }

//    public void CheckIn()
//    {
//        Console.WriteLine("movediiii:" + DateTime.Now);
//    }

//    public void CheckOut()
//    {
//        Console.WriteLine("wavediiii:" + DateTime.Now);
//    }
//}


//public class Teacher : Employee
//{
//    public string subject { get; set; }
//    public void Teach()
//    {
//        age = 10;
//        Console.WriteLine("Teaching:" + subject);
//    }
//}

//public class Janitor : Employee
//{
//    public void Clean()
//    {
//        Console.WriteLine("Cleaning");
//    }
//}

//polymorphism

//class program {
//    static void Main(string[] args)
//    {
//        employee[] employee = new employee[3];
//        employee[0] = new Teacher() { name = "masw", age = 25, subject = "oop" };
//        employee[1] = new Teacher() { name = "shota", age = 26, subject = "polymorphism" };
//        employee[2] = new Janitor() { name = "zurabi", age = 47 };

//        foreach (var item in employee)
//        {
//            item.PerformDuty();
//        }
//    }
//}

//public class employee
//{
//    //properties
//    public string name { get; set; } = "Default";
//    public int age { get; set; }

//    public virtual void PerformDuty()
//    {
//        Console.WriteLine("Performing Duty");
//    }
//}

//public class Teacher : employee
//{
//    //prpr

//    public string subject { get; set; }

//    private void Teach()
//    {
//        Console.WriteLine("Teaching" + "-" + age.ToString() + "-" + name);
//    }
//    public override void PerformDuty()
//    {
//        Teach();
//    }
//}

//public class Janitor : employee
//{
//    //ppp
//    private void clean()
//    {
//        Console.WriteLine("Cleaning" + "-" + age.ToString() + "-" + name);
//    }
//    public override void PerformDuty()
//    {
//        clean();
//    }
//}

class program
{
    static void Main(string[] args)
    {
        Animalworks[] kingdom = new Animalworks[2];
        kingdom[0] = new Mammal() { Name = "Cat", speed = "10 km/h", age = 2, sound = "meow" };
        kingdom[1] = new Avian() { Name = "Crow", speed = "15 km/h", age = 4, sound = "caw" };

        foreach (var item in kingdom)
        {
            item.AnimalFunctions();
        }
    }
        
    public class Animalworks
    {
        public string Name { get; set; }
        public string sound { get; set; }
        public string speed { get; set; }
        public int age { get; set; }

        public virtual void AnimalFunctions()
        {
            Console.WriteLine("it is, in fact, functioning");
        }
    }

    public class Mammal : Animalworks
    {
        private void zoo()
        {
            Console.WriteLine(Name + "|" + "Running at:" + speed + "|" + "Aged:" + age.ToString() + "|" + "Currently making this sound:" + sound);
        }
        public override void AnimalFunctions()
        {
            zoo();
        }
    }

    public class Avian : Animalworks
    {
        private void aviary()
        {
            Console.WriteLine(Name + "|" + "Flying at:" + speed + "|" + "Aged:" + age.ToString() + "|" + "Currently making this sound:" + sound);
        }
        public override void AnimalFunctions()
        {
            aviary();
        }
    }
}