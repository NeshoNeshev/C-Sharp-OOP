using System;

namespace BoxData
{
    
    public class Box
    {
        const int MIN_SIDE_VALUE = 0;
        const int num = 2;
        private double length;
        private double width;
        private double height;
        private double result = 0;
        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get => this.length;
            set
            {
                if (value <= MIN_SIDE_VALUE)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            get => this.width;
            set
            {
                if (value <= MIN_SIDE_VALUE)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get => this.height;
            set
            {
                if (value <= MIN_SIDE_VALUE)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }

                height = value;
            }
        }
        public double LateralSurfaceArea()
        {

            result = num * (this.Length * this.Height) + num * (this.Width * this.Height);
            return this.result;
        }
        public double SurfaceArea()
        {
            // 2lw + 2lh + 2wh
            result = num * (this.length * this.width) + num * (this.length * this.height) + num * (this.width * this.height);
            return result;
        }
        public double Volume()
        {
            //lwh
            result = this.length * this.width * this.height;
            return result;
        }
        
    }
}
