﻿namespace Connectives.Common
{
    public static class MeasurementConverters
    {
        static void ConvertTo(this WidthMeasurement measurement, DistanceUnit targetUnit)
        {
            if (measurement.Unit != targetUnit)
            {
            }
        }

        static void ConvertTo(this LengthMeasurement measurement, DistanceUnit targetUnit)
        {
            if (measurement.Unit != targetUnit)
            {
            }
        }

        static void ConvertTo(this AngleMeasurement measurement, AngleUnit targetUnit)
        {
            if (measurement.Unit != targetUnit)
            {
            }
        }

        static void ConvertTo(this TimeMeasurement measurement, TimeUnit targetUnit)
        {
            if (measurement.Unit != targetUnit)
            {
            }
        }
    }
}
