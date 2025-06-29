namespace The_this_Pointer
{

    class clsEmployee
    {

        public int id;
        public string name;
        public float salary;

        public clsEmployee(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void Print()
        {
            // Console.WriteLine(this.id+" "+this.name+" "+this.salary);
            Console.WriteLine(id+" "+name+" "+salary);
        }

        public static void Fun1(clsEmployee emp)
        {

            emp.Print();

        }

        public void Fun2()
        {
            Fun1(this);          
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            clsEmployee employee1 = new clsEmployee(3760, "Abdelrahman", 20000);

            employee1.Fun2();

            Console.ReadKey();

        }
    }
}