using System;
using System.Text;
using System.Collections.Generic;

class Gsm
{
    private string model;
    private string manifacturer;
    private int? price;
    private string owner;

    public Battery Battery = new Battery(BatteryType.LiIon, null, null);
    public Display Display = new Display(0, null);

    private static readonly Gsm iPhone = new Gsm("iPhone", "Apple", 935);

    public Gsm(string model, string manifacturer)
        : this(model, manifacturer, null, null, null, null)
    {

    }

    public Gsm(string model, string manifacturer, int price)
        : this(model, manifacturer, price, null, null, null)
    {

    }

    public Gsm(string model, string manufacturer, int? price, string owner)
        : this(model, manufacturer, price, owner, null, null)
    {
    }

    public Gsm(string model, string manufacturer, int? price, string owner, Battery battery, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;
    }

    private readonly List<Call> callHistory = new List<Call>();

    public static Gsm IPhone
    {
        get { return iPhone; }
    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value.Length >= 0)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manifacturer;
        }
        set
        {
            if (value.Length >= 0)
            {
                this.manifacturer = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value == null || value >= 0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value == null || value.Length >= 0)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public void AddCall(DateTime now, int number, int duration)
    {
        Call myCall = new Call(now, number, duration);
        callHistory.Add(myCall);
    }

    public void RemoveCall(int number)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].DialedNumber == number)
            {
                callHistory.RemoveAt(i);
                i--;
            }
        }
    }

    public void ClearHistory()
    {
        callHistory.Clear();
    }

    public double CallPrice(double pricePerMin)
    {
        double time = 0;
        for (int i = 0; i < callHistory.Count; i++)
        {
            time = time + callHistory[i].Duration;
        }
        double price = pricePerMin * (time / 60);
        return price;
    }

    public override string ToString()
    {
        StringBuilder endText = new StringBuilder();
        endText.AppendLine("GSM:");
        endText.Append("Model: ");
        endText.AppendLine(this.model);
        endText.Append("Manifacturer: ");
        endText.AppendLine(this.manifacturer);
        endText.Append("Price: ");
        endText.AppendLine(this.price.ToString());
        endText.Append("lv.");
        endText.Append("Owner: ");
        endText.AppendLine(this.owner);
        endText.AppendLine(this.Battery.ToString());
        endText.AppendLine(this.Display.ToString());
        string result = endText.ToString();
        return result;
    }
}