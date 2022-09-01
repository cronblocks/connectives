namespace Connectives.Common
{
    public class WidthMeasurement
    {
        public DistanceUnit Unit { get; set; } = DistanceUnit.MilliMeter;
        public double Measurement { get; set; } = 0;
    }

    public class LengthMeasurement
    {
        public DistanceUnit Unit { get; set; } = DistanceUnit.MilliMeter;
        public double Measurement { get; set; } = 0;
    }

    public class AngleMeasurement
    {
        public AngleUnit Unit { get; set; } = AngleUnit.Degree;
        public double Measurement { get; set; } = 0;
    }

    public class TimeMeasurement
    {
        public TimeUnit Unit { get; set; } = TimeUnit.Millisecond;
        public double Measurement { get; set; } = 0;
    }
}
