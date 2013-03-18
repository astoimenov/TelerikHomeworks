using System;

class IndividualCustomer : Customer
{
    // Fields
    private string egn;

    // Constructor
    public IndividualCustomer()
        : this(string.Empty, string.Empty) { }

    public IndividualCustomer(string name, string phoneNumber)
        : this(name, phoneNumber, string.Empty) { }

    public IndividualCustomer(string name, string phoneNumber, string egn)
        : base(name, phoneNumber)
    {
        this.egn = egn;
    }

    // Properties
    public string Egn
    {
        get { return this.egn; }
        set { this.egn = value; }
    }
}