namespace Connectives.Common
{
    public class Width
    {
        public WidthUnit Unit { get; set; } = WidthUnit.MilliMeter;
        public double Measurement { get; set; } = 0;
    }

    public class Length
    {
        public LengthUnit Unit { get; set; } = LengthUnit.MilliMeter;
        public double Measurement { get; set; } = 0;
    }

    public class Angle
    {
        public AngleUnit Unit { get; set; } = AngleUnit.Degree;
        public double Measurement { get; set; } = 0;
    }
}
