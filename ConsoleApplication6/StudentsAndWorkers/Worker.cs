namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private decimal MoneyPerHour;
        public Worker(string firstName, string lastName, double workHPerDay, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHPerDay = workHPerDay;
            this.WeekSalary = weekSalary;
            this.MoneyPerHour = GetMoneyPerHour();
        }
        public double WorkHPerDay { get; set; }

        public decimal WeekSalary { get; set; }

        public decimal MoneyPerH
        {
            get
            {
                return this.MoneyPerHour;
            }
            set
            {
                this.MoneyPerHour = GetMoneyPerHour();
            }
        }

        private decimal GetMoneyPerHour()
        {
            return this.WeekSalary / (decimal)(this.WorkHPerDay * 5);
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} {this.MoneyPerHour}";
        }
    }
}
