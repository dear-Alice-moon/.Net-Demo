using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_160909_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  自写程序！！！ 

            //Shape cir = new Circle();
            //Square squ = new Square();
            //Rectangle rec = new Rectangle();

            //cir.MianJi(4, 0);
            //cir.ZhouChang(4, 0);

            //squ.MianJi(4, 3);
            //squ.ZhouChang(4, 3);

            //rec.MianJi(4, 4);
            //rec.ZhouChang(4, 4);

            //Console.ReadKey();

            #endregion

            #region  视频中老师所讲代码
            Shape cir = new Circle(20);
            Console.WriteLine("圆的周长为：{0}", cir.GetGirth());
            Console.WriteLine("圆的面积为：{0}", cir.GetArea());

            Rectangle rec = new Rectangle(10, 20.12);
            Console.WriteLine("长方形的周长为：{0}", rec.GetGirth());
            Console.WriteLine("长方形的面积为：{0}", rec.GetArea());

            Console.ReadKey();

            #endregion

        }
    }

    #region  自写程序！！！
    //abstract class Shape 
    //{
    //    //double a, b;
    //    public abstract void MianJi(double a, double b);

    //    public abstract void ZhouChang(double a, double b);

    //}

    //class Circle : Shape 
    //{
    //    double Π = 3.14;
    //    double s, c;
    //    public override void MianJi(double r, double b)
    //    {
    //        s = Π * r * r;
    //        Console.WriteLine("圆的面积为：{0}", s);
    //    }

    //    public override void ZhouChang(double r, double b)
    //    {
    //        c = 2 * Π * r;
    //        Console.WriteLine("圆的周长是：{0}", c);
    //    }

    //}

    //class Square : Shape 
    //{
    //    double s, c;

    //    public override void MianJi(double a, double b)
    //    {
    //        s = a * b;
    //        Console.WriteLine("矩形的面积为：{0}", s);
    //    }

    //    public override void ZhouChang(double a, double b)
    //    {
    //        c = 2 * (a + b);
    //        Console.WriteLine("矩形的周长为：{0}", c);
    //    }

    //}

    //class Rectangle : Shape
    //{
    //    double s, c;
    //    public override void MianJi(double a, double b)
    //    {
    //        s = a * b;
    //        Console.WriteLine("正方形的面积为：{0}", s);
    //    }

    //    public override void ZhouChang(double a, double b)
    //    {
    //        c = 2 * (a + b);
    //        Console.WriteLine("正方形的周长为：{0}", s);
    //    }
    //}
 
    #endregion

    #region  视频中老师所讲代码
    abstract class Shape 
    {
        public abstract double GetArea();

        public abstract double GetGirth();
    }

    class Circle : Shape
    {
        public Circle(double r) 
        {
            this.R = r;
        }
        public double R { get; set; }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetGirth()
        {
            return 2 * Math.PI * this.R;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double length, double width) 
        {
            this.Length = length;
            this.Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public override double GetArea()
        {
            return this.Length * this.Width;
        }

        public override double GetGirth()
        {
            return 2 * (this.Length + this.Width);
        }
    }

    class Square : Shape
    {
        public Square(double length) 
        {
            this.Length = length;
        }

        public double Length { get; set; }
        public override double GetArea()
        {
            return this.Length * this.Length;
        }

        public override double GetGirth()
        {
            return 4 * this.Length;
        }
    }


    #endregion

}
