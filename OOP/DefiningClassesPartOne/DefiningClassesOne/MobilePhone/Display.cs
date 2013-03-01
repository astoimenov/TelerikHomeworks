using System;
using System.Text;

class Display
{
    private byte size;
    private int? numColors;

    public Display(byte size)
        : this(size, null)
    {

    }

    public Display(byte size, int? numColors)
    {
        this.Size = size;
        this.NumColors = numColors;
    }

    public byte Size
    {
        get { return this.size; }
        set
        {
            if (value >= 0)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int? NumColors
    {
        get{return this.numColors;}
        set
        {
            if (value>=0||value==null)
            {
                this.numColors = value;
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
        endText.AppendLine("Display:");
        endText.Append("Size: ");
        endText.AppendLine(this.size.ToString() + " inches");
        endText.Append("Colors: ");
        endText.AppendLine(this.numColors.ToString() + " millions");
        return endText.ToString();
    }
}