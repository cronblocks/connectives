namespace Connectives.Common
{
    public static class MeasurementConverters
    {
        static WidthMeasurement ConvertTo(this WidthMeasurement measurement, DistanceUnit targetUnit)
        {
            if (measurement.Unit == targetUnit)
            {
                return measurement;
            }

            return null;
        }

        static LengthMeasurement ConvertTo(this LengthMeasurement measurement, DistanceUnit targetUnit)
        {
            if (measurement.Unit == targetUnit)
            {
                return measurement;
            }

            return null;
        }

        static AngleMeasurement ConvertTo(this AngleMeasurement measurement, AngleUnit targetUnit)
        {
            if (measurement.Unit == targetUnit)
            {
                return measurement;
            }

            return null;
        }

        static TimeMeasurement ConvertTo(this TimeMeasurement measurement, TimeUnit targetUnit)
        {
            if (measurement.Unit == targetUnit)
            {
                return measurement;
            }
            
            return null;
        }
    }
}
