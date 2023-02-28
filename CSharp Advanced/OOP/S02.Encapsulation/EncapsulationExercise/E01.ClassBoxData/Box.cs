using System;

namespace E01.ClassBoxData
{
    internal class Box
    {
        private double lenght;
        private double width;
        private double height;

        private const string errorMessage = "{0} cannot be zero or negative.";

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(errorMessage, nameof(Lenght)));
                }
                else
                {
                    lenght = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(errorMessage, nameof(Width)));
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(errorMessage, nameof(Height)));
                }
                else
                {
                    height = value;
                }
            }
        }

        public string SurfaceArea()
        {
            double surfaceArea = (2 * lenght * width) + (2 * lenght * height) + (2 * width * height);

            return $"Surface Area - {surfaceArea:f2}";
        }
        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * lenght * height + 2 * width * height;

            return $"LateralSurfaceArea - {lateralSurfaceArea:f2}";
        }
        public string Volume()
        {
            double volume = lenght * width * height;

            return $"Volume - {volume:f2}";
        }
    }
}
