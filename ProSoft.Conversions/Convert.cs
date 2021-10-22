namespace Library.Data.Measurement
{
    public class Convert
    {
        public class Millimeters
        {
            public static double ToInches(double inputValue)
            {
                return inputValue * 0.03937;
            }
        }

        public class Centimeters
        {
            public static double ToMm(double inputValue)
            {
                return inputValue * 10;
            }

            public static double ToInches(double inputValue)
            {
                return inputValue * 0.3937;
            }
        }

        public class Meters
        {
            public static double ToMm(double inputValue)
            {
                return inputValue * 1000;
            }

            public static double ToCm(double inputValue)
            {
                return inputValue * 100;
            }

            public static double ToFeet(double inputValue)
            {
                return inputValue * 3.281;
            }
        }

        public class MetersPerSecond
        {
            public static double ToFps(double inputValue)
            {
                return inputValue * 3.281;
            }
        }

        public class SquareMeters
        {
            public static double ToSqrFeet(double inputValue)
            {
                return inputValue * 10.76;
            }

            public static double ToSqrYards(double inputValue)
            {
                return inputValue * 1.196;
            }

            public static double ToSqrAcres(double inputValue)
            {
                return inputValue * 0.0002471;
            }
        }

        public class CubicMeters
        {
            public static double ToCubFeet(double inputValue)
            {
                return inputValue * 35.31;
            }

            public static double ToCubYards(double inputValue)
            {
                return inputValue * 1.308;
            }

            public static double ToAcreFeet(double inputValue)
            {
                return inputValue * 0.0008107;
            }
        }

        public class CubicMetersPerSecond
        {
            public static double ToCubFeetSec(double inputValue)
            {
                return inputValue * 35.31;
            }

            public static double ToCubGallonMin(double inputValue)
            {
                return inputValue * 15850.00;
            }
        }

        public class Kilometers
        {
            public static double ToMeters(double inputValue)
            {
                return inputValue * 1000;
            }

            public static double ToMiles(double inputValue)
            {
                return inputValue * 0.6214;
            }
        }

        public class SquareKilometers
        {
            public static double ToSqrMiles(double inputValue)
            {
                return inputValue * 0.3861;
            }
        }

        public class CubicKilometers
        {
            public static double ToCubMiles(double inputValue)
            {
                return inputValue * 0.2399;
            }
        }

        public class Inches
        {
            public static double ToMm(double inputValue)
            {
                return inputValue * 25.4;
            }

            public static double ToCm(double inputValue)
            {
                return inputValue * 2.54;
            }
        }

        public class SquareInches
        {
            public static double ToSqrCm(double inputValue)
            {
                return inputValue * 6.4516;
            }
        }

        public class Feet
        {
            public static double ToInches(double inputValue)
            {
                return inputValue * 12;
            }

            public static double ToMeters(double inputValue)
            {
                return inputValue * 0.3048;
            }
        }

        public class SquareFeet
        {
            public static double ToSqrMeters(double inputValue)
            {
                return inputValue * 0.09294;
            }
        }

        public class CubicFeet
        {
            public static double ToCubMeters(double inputValue)
            {
                return inputValue * 0.02832;
            }
        }

        public class AcreFoot
        {
            public static double ToCubicMeters(double inputValue)
            {
                return inputValue * 1233;
            }

        }

        public class Yards
        {
            public static double ToFeet(double inputValue)
            {
                return inputValue * 3;
            }

            public static double ToMeters(double inputValue)
            {
                return inputValue * 0.9144;
            }
        }

        public class Miles
        {
            public static double ToFeet(double inputValue)
            {
                return inputValue * 5280;
            }

            public static double ToMeters(double inputValue)
            {
                return inputValue * 1609.3;
            }

            public static double ToKm(double inputValue)
            {
                return inputValue * 1.609;
            }
        }
        public class SquareMiles
        {
            public static double ToSqrKm(double inputValue)
            {
                return inputValue * 2.590;
            }
        }
        public class CubicMiles
        {
            public static double ToCubKm(double inputValue)
            {
                return inputValue * 4.168;
            }
        }
        public class MacroRadian
        {
            public static double ToSecOfArc(double inputValue)
            {
                return inputValue * 0.2;
            }
        }
    }

    public class Temperature
    {
        public class Fahrenheit
        {
            public static double ToCelsius(double inputValue)
            {
                return inputValue - 32 * (5 / 9);
            }
        }
        public class Celsius
        {
            public static double ToFahrenheit(double inputValue)
            {
                return (inputValue * 2) - (inputValue * 2 * 0.1) + 32;
            }
        }

    }

    public class WeightsAndMeasures
    {
        public class Cup
        {
            public static double ToOunces(double inputValue)
            {
                return inputValue * 8;
            }

            public static double ToTablespoons(double inputValue)
            {
                return inputValue * 16;
            }

            public static double ToTeaspoons(double inputValue)
            {
                return inputValue * 48;
            }
        }

        public class Gallons
        {

            public static double ToCubFeet(double inputValue)
            {
                return inputValue * 0.1337;
            }

            public static double ToCubInches(double inputValue)
            {
                return inputValue * 231;
            }

            public static double ToLiters(double inputValue)
            {
                return inputValue * 3.785;
            }

            public static double ToPoundsOfWater(double inputValue)
            {
                return inputValue * 8.336;
            }

            public static double ToOuncesOfWater(double inputValue)
            {
                return inputValue * 133.376;
            }
        }

        public class Liter
        {
            public static double ToCubMeter(double inputValue)
            {
                return inputValue * 0.001;
            }

            public static double ToQuart(double inputValue)
            {
                return inputValue * 1.057;
            }

            public static double ToGallons(double inputValue)
            {
                return inputValue * 0.2642;
            }

            public static double ToCubicFeet(double inputValue)
            {
                return inputValue * 0.03531;
            }
        }

        public class Ounces
        {
            public static double ToPounds(double inputValue)
            {
                return inputValue * 0.0625;
            }

            public static double ToGrams(double inputValue)
            {
                return inputValue * 28.35;
            }

            public static double ToGrains(double inputValue)
            {
                return inputValue * 437.5;
            }
        }

        public class Pounds
        {
            public static double ToOuncesAvo(double inputValue)
            {
                return inputValue * 16;
            }

            public static double ToKiloAvo(double inputValue)
            {
                return inputValue * 0.4536;
            }

            public static double ToGrainsAvo(double inputValue)
            {
                return inputValue * 7000;
            }

            public static double ToPoundsTroy(double inputValue)
            {
                return inputValue * 1.2153;
            }
        }

        public class Quart
        {
            public static double ToPints(double inputValue)
            {
                return inputValue * 2;
            }

            public static double ToGallons(double inputValue)
            {
                return inputValue * 0.25;
            }

            public static double ToLiters(double inputValue)
            {
                return inputValue * 0.9464;
            }

            public static double ToPoundsOfWater(double inputValue)
            {
                return inputValue * 2.084;
            }
        }

    }

}
