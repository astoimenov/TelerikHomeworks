using System;

class Worker : Human
{
    private int weekSalary;
    private int workHourPerDay;
    private decimal salaryPerHour;

    public Worker(int weekSalary, int workHourPerDay, string firstName, string lastName, decimal salaryPerHour = 0)
        : base(firstName, lastName) 
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkHourPerDay = workHourPerDay;
        this.SalaryPerHour = salaryPerHour;
    }

    public int WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value > 0)
            {
                this.weekSalary = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public int WorkHourPerDay
    {
        get { return this.workHourPerDay; }
        set
        {
            if (value > 0)
            {
                this.workHourPerDay = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public decimal SalaryPerHour
    {
        get { return this.salaryPerHour; }
        set
        {
            if (value > 0)
            {
                this.salaryPerHour = value;
            }
            else
            {
                //throw new ArgumentOutOfRangeException();
            }
        }
    }

    public decimal MoneyPerHour()
    {
        decimal perHour = this.weekSalary / ((decimal)this.workHourPerDay * 5);
        return perHour;
    }

    public override string ToString()
    {
        return String.Format("{0} {1} win {2:F2}", this.FirstName, this.LastName, this.salaryPerHour);
    }
}