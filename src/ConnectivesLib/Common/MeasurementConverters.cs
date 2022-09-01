namespace Connectives.Common
{
    public static class MeasurementConverters
    {
        public static void ConvertTo(this WidthMeasurement measurement, DistanceUnit targetUnit)
        {
            if (measurement == null) return;

            if (measurement.Unit != targetUnit)
            {
            }
        }

        public static void ConvertTo(this LengthMeasurement measurement, DistanceUnit targetUnit)
        {
            if (measurement == null) return;

            if (measurement.Unit != targetUnit)
            {
            }
        }

        public static void ConvertTo(this AngleMeasurement measurement, AngleUnit targetUnit)
        {
            if (measurement == null) return;

            if (measurement.Unit != targetUnit)
            {
            }
        }

        public static void ConvertTo(this TimeMeasurement measurement, TimeUnit targetUnit)
        {
            if (measurement == null) return;

            if (measurement.Unit != targetUnit)
            {
            }
        }
    }
}
