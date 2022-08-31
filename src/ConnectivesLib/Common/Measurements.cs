namespace Connectives.Common
{
    public class Width
    {
        public DistanceUnit Unit { get; set; } = DistanceUnit.MilliMeter;
        public double Measurement { get; set; } = 0;
    }

    public class Length
    {
        public DistanceUnit Unit { get; set; } = DistanceUnit.MilliMeter;
        public double Measurement { get; set; } = 0;
    }

    public class Angle
    {
        public AngleUnit Unit { get; set; } = AngleUnit.Degree;
        public double Measurement { get; set; } = 0;
    }
}
