namespace Primeiro
{
    class Funcionario {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {
            Salary *= (1.00 + percentage/100.00);
        }

        public override string ToString() {
            return ($"{Id}, {Name}, {Salary:F2}");
        }
    }
}
