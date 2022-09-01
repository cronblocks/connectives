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
                        default: return 0.0;
                    }
                case AngleUnit.Radian:
                    switch (to)
                    {
                        case AngleUnit.Degree:      return 0.0;
                        case AngleUnit.Radian:      return 1.0;
                        case AngleUnit.MilliRadian: return 0.0;
                        default: return 0.0;
                    }
                case AngleUnit.MilliRadian:
                    switch (to)
                    {
                        case AngleUnit.Degree:      return 0.0;
                        case AngleUnit.Radian:      return 0.0;
                        case AngleUnit.MilliRadian: return 1.0;
                        default: return 0.0;
                    }
                default: return 0.0;
            }
        }

        public static double GetTimeConversionFactor(TimeUnit from, TimeUnit to)
        {

        }
    }
}
