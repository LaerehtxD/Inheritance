using System;

public class Shape {
  public int height;
  public int width;
  public string Formula;
  public Shape(int height, int width, string Formula) {
    this.height = height;
    this.width = width;
    this.Formula = Formula;
  }
}

public class Circle: Shape {
  public int radius;
  public double pi;
  public double circumference;
  public Circle(int height, int width, string Formula, int radius, double pi): base(height, width, Formula) {
    this.radius = radius;
    this.pi = pi;
    this.circumference = 2 * pi * radius;

  }
  public void ShowAns() {
    Console.Write("Formula for circle circumference: ");
    Console.WriteLine(Formula);
    Console.WriteLine("Answer: ");
    Console.WriteLine(circumference);
  }

}

public class Rectangle: Shape {
  int recPerimeter;
  public Rectangle(int height, int width, string Formula): base(height, width, Formula) {
    this.recPerimeter = 2 * (height + width);

  }
  public void ShowAns() {
    Console.Write("Formula for rectangle perimeter: ");
    Console.WriteLine(Formula);
    Console.WriteLine("Answer: ");
    Console.WriteLine(recPerimeter);
  }
}

public class Square: Shape {
  int area;
  public Square(int height, int width, string Formula): base(height, width, Formula) {
    this.area = width * width;

  }
  public void ShowAns() {
    Console.Write("Formula for square area: ");
    Console.WriteLine(Formula);
    Console.WriteLine("Answer: ");
    Console.WriteLine(area);
  }
}
public class Triangle: Shape {
  int triArea;
  public Triangle(int height, int width, string Formula): base(height, width, Formula) {
    int hw = height * width;
    this.triArea = hw / 2;

  }
  public void ShowAns() {
    Console.Write("Formula for triangle area: ");
    Console.WriteLine(Formula);
    Console.WriteLine("Answer: ");
    Console.WriteLine(triArea);
  }
}
public class Program {
  static void Main(string[] args) {
    Circle circle = new Circle(10, 10, "C=2*pi*radius", 3, 3.1415);
    circle.ShowAns();
    Rectangle rect = new Rectangle(10, 10, "P=2(lenght+width)");
    rect.ShowAns();
    Square square = new Square(10, 10, "A=width*width");
    square.ShowAns();
    Triangle tri = new Triangle(10, 10, "A=(height*base)/2");
    tri.ShowAns();
  }
}
