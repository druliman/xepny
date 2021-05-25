using System;

namespace ConsoleApp11
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
	class Triangle : Figure
	{
		public Triangle(Point a, Point b, Point c)
		{
			arr = new Point[3];
			arr[0] = a;
			arr[1] = b;
			arr[3] = c;
		}
		public override void createfigura()
		{

		}
	}

	class Square : Figure
	{
		
		public Square(Point a, Point b, Point c, Point d)
		{
			arr = new Point[4];
			arr[0] = a;
			arr[1] = b;
			arr[2] = c;
			arr[3] = d;
		}
		
		public override void createfigura()
		{
		 
		}
	}

	class Oval : Figure
	{
		public Oval(Point center, int R, Point a, Point b, Point c, Point d)
		{
			arr = new Point[5];
			arr[0] = center;
			arr[1] = a;
			arr[2] = b;
			arr[3] = c;
			arr[4] = d;
		}
		public override void createfigura()
		{

		}
	}
	
	class Circle : Figure
	{
		public Circle(Point center, int R)
		{
			arr = new Point[1];
			arr[0] = center;
		}
		public override void createfigura()
		{

		}
	}

	class Figure
	{
		public Point[] arr;

		public Figure()
		{
		 
		}
		public virtual void createfigura()
		{
			//аrchеr
		}
	}
	class Point
	{
		protected int x, y;
		public Point( int x, int y)
		{ 
			this.x = x;
			this.x = y;
		}
	}
	class Line
	{
		protected int width = 0;
		protected int height = 0;
		public Line(int width, int height)
		{
			this.height = height;
			this.width = width;
		}
			
		
	}
}
	