namespace Connectives.Common
{
    public enum DistanceUnit
    {
        Pixel,
        PercentageCanvasWidth,
        PercentageCanvasHeight,
        Inch,
        MilliMeter
    }

    public enum AngleUnit
    {
        Degree,
        Radian,
        MilliRadian
    }

    public enum TimeUnit
    {
        Nanosecond,
        Microsecond,
        Millisecond,
        Second,
        Minute,
        Hour
    }

    internal static class ConversionFactors
    {
        public static double GetDistanceConversionFactor(DistanceUnit from, DistanceUnit to)
        {
            switch (from)
            {
                case DistanceUnit.Pixel:
                    switch (to)
                    {
                        case DistanceUnit.Pixel:                  return 1.0;
                        case DistanceUnit.PercentageCanvasWidth:  return 0.0;
                        case DistanceUnit.PercentageCanvasHeight: return 0.0;
                        case DistanceUnit.Inch:                   return 0.0;
                        case DistanceUnit.MilliMeter:             return 0.0;
                        default:                                  return 0.0;
                    }
                case DistanceUnit.PercentageCanvasWidth:
                    switch (to)
                    {
                        case DistanceUnit.Pixel:                  return 0.0;
                        case DistanceUnit.PercentageCanvasWidth:  return 1.0;
                        case DistanceUnit.PercentageCanvasHeight: return 0.0;
                        case DistanceUnit.Inch:                   return 0.0;
                        case DistanceUnit.MilliMeter:             return 0.0;
                        default:                                  return 0.0;
                    }
                case DistanceUnit.PercentageCanvasHeight:
                    switch (to)
                    {
                        case DistanceUnit.Pixel:                  return 0.0;
                        case DistanceUnit.PercentageCanvasWidth:  return 0.0;
                        case DistanceUnit.PercentageCanvasHeight: return 1.0;
                        case DistanceUnit.Inch:                   return 0.0;
                        case DistanceUnit.MilliMeter:             return 0.0;
                        default:                                  return 0.0;
                    }
                case DistanceUnit.Inch:
                    switch (to)
                    {
                        case DistanceUnit.Pixel:                  return 0.0;
                        case DistanceUnit.PercentageCanvasWidth:  return 0.0;
                        case DistanceUnit.PercentageCanvasHeight: return 0.0;
                        case DistanceUnit.Inch:                   return 1.0;
                        case DistanceUnit.MilliMeter:             return 0.0;
                        default:                                  return 0.0;
                    }
                case DistanceUnit.MilliMeter:
                    switch (to)
                    {
                        case DistanceUnit.Pixel:                  return 0.0;
                        case DistanceUnit.PercentageCanvasWidth:  return 0.0;
                        case DistanceUnit.PercentageCanvasHeight: return 0.0;
                        case DistanceUnit.Inch:                   return 0.0;
                        case DistanceUnit.MilliMeter:             return 1.0;
                        default:                                  return 0.0;
                    }
                default: return 0.0;
            }
        }

        public static double GetAngleConversionFactor(AngleUnit from, AngleUnit to)
        {
            switch (from)
            {
                case AngleUnit.Degree:
                    switch (to)
                    {
                        case AngleUnit.Degree:      return 1.0;
                        case AngleUnit.Radian:      return 0.0;
                        case AngleUnit.MilliRadian: return 0.0;
                        default:                    return 0.0;
                    }
                case AngleUnit.Radian:
                    switch (to)
                    {
                        case AngleUnit.Degree:      return 0.0;
                        case AngleUnit.Radian:      return 1.0;
                        case AngleUnit.MilliRadian: return 0.0;
                        default:                    return 0.0;
                    }
                case AngleUnit.MilliRadian:
                    switch (to)
                    {
                        case AngleUnit.Degree:      return 0.0;
                        case AngleUnit.Radian:      return 0.0;
                        case AngleUnit.MilliRadian: return 1.0;
                        default:                    return 0.0;
                    }
                default: return 0.0;
            }
        }

        public static double GetTimeConversionFactor(TimeUnit from, TimeUnit to)
        {
            switch (from)
            {
                case TimeUnit.Nanosecond:
                    switch (to)
                    {
                        case TimeUnit.Nanosecond:  return 1.0;
                        case TimeUnit.Microsecond: return 0.0;
                        case TimeUnit.Millisecond: return 0.0;
                        case TimeUnit.Second:      return 0.0;
                        case TimeUnit.Minute:      return 0.0;
                        case TimeUnit.Hour:        return 0.0;
                        default:                   return 0.0;
                    }
                case TimeUnit.Microsecond:
                    switch (to)
                    {
                        case TimeUnit.Nanosecond:  return 0.0;
                        case TimeUnit.Microsecond: return 1.0;
                        case TimeUnit.Millisecond: return 0.0;
                        case TimeUnit.Second:      return 0.0;
                        case TimeUnit.Minute:      return 0.0;
                        case TimeUnit.Hour:        return 0.0;
                        default:                   return 0.0;
                    }
                case TimeUnit.Millisecond:
                    switch (to)
                    {
                        case TimeUnit.Nanosecond:  return 0.0;
                        case TimeUnit.Microsecond: return 0.0;
                        case TimeUnit.Millisecond: return 1.0;
                        case TimeUnit.Second:      return 0.0;
                        case TimeUnit.Minute:      return 0.0;
                        case TimeUnit.Hour:        return 0.0;
                        default:                   return 0.0;
                    }
                case TimeUnit.Second:
                    switch (to)
                    {
                        case TimeUnit.Nanosecond:  return 0.0;
                        case TimeUnit.Microsecond: return 0.0;
                        case TimeUnit.Millisecond: return 0.0;
                        case TimeUnit.Second:      return 1.0;
                        case TimeUnit.Minute:      return 0.0;
                        case TimeUnit.Hour:        return 0.0;
                        default:                   return 0.0;
                    }
                case TimeUnit.Minute:
                    switch (to)
                    {
                        case TimeUnit.Nanosecond:  return 0.0;
                        case TimeUnit.Microsecond: return 0.0;
                        case TimeUnit.Millisecond: return 0.0;
                        case TimeUnit.Second:      return 0.0;
                        case TimeUnit.Minute:      return 1.0;
                        case TimeUnit.Hour:        return 0.0;
                        default:                   return 0.0;
                    }
                case TimeUnit.Hour:
                    switch (to)
                    {
                        case TimeUnit.Nanosecond:  return 0.0;
                        case TimeUnit.Microsecond: return 0.0;
                        case TimeUnit.Millisecond: return 0.0;
                        case TimeUnit.Second:      return 0.0;
                        case TimeUnit.Minute:      return 0.0;
                        case TimeUnit.Hour:        return 1.0;
                        default:                   return 0.0;
                    }
                default: return 0.0;
            }
        }
    }
}
