using System;
using System.Text;

public enum BatteryType { LiPo, LiIon, NiCd };

class Battery
{
    private BatteryType battModel;
    private uint? hoursIdle;
    private uint? hoursTalk;

    public Battery(BatteryType battModel)
        : this(battModel, null, null)
    {

    }

    public Battery(BatteryType battModel, uint? hoursIdle)
        : this(battModel, hoursIdle, null)
    {

    }

    public Battery(BatteryType battModel, uint? hoursIdle, uint? hoursTalk)
    {
        this.BattModel = battModel;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    public BatteryType BattModel
    {
        get { return this.battModel; }
        set { this.battModel = value; }
    }

    public uint? HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value >= 0 || value == null)
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public uint? HoursTalk
    {
        get { return this.hoursTalk; }
        set
        {
            if (value >= 0 || value == null)
            {
                this.hoursTalk = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public override string ToString()
    {
        StringBuilder endText = new StringBuilder();
        endText.AppendLine("Battery:");
        endText.Append("Type: ");
        endText.AppendLine(this.battModel.ToString());
        endText.Append("Hours idle: ");
        endText.AppendLine(this.hoursIdle.ToString());
        endText.Append("Hours talk: ");
        endText.AppendLine(this.hoursTalk.ToString());
        return endText.ToString();
    }
}