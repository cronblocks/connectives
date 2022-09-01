namespace Connectives.Common
{
    public static class MeasurementConverters
    {
        static WidthMeasurement ConvertTo(this WidthMeasurement measurement, DistanceUnit targetUnit)
        {
            return measurement;
        }

        static LengthMeasurement ConvertTo(this LengthMeasurement measurement, DistanceUnit targetUnit)
        {
            return measurement;
        }

        static AngleMeasurement ConvertTo(this AngleMeasurement measurement, AngleUnit targetUnit)
        {
            return measurement;
        }

        static TimeMeasurement ConvertTo(this TimeMeasurement measurement, TimeUnit targetUnit)
        {
            return measurement;
        }
    }
}
