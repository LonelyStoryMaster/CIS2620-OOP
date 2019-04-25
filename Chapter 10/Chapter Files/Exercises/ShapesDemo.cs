using System;
using static System.Console;

class ShapesDemo {
    static void Main() {
        GeometricShape[] shapes;
        shapes = generateShapes(30, 5, 75, 5, 75);
        foreach(GeometricShape shape in shapes) {
            WriteLine(shape);
        }
    }

    static GeometricShape[] generateShapes(int numShapes, int minHeight, int maxHeight, int minWidth, int maxWidth) {
        GeometricShape[] shapes = new GeometricShape[numShapes];
        Random rando = new Random();
        int width, height, shapeType;
        for (int i = 0; i < shapes.Length; i++) {
            GeometricShape newShape;
            width = rando.Next(minWidth, maxWidth);
            height = rando.Next(minHeight, maxHeight);
            shapeType = rando.Next(0, 3);
            if (shapeType == 0) newShape = new Triangle(height, width);
            else if (shapeType == 1) { newShape = new Rectangle(height, width); }
            else if (shapeType == 2) { newShape = new Square(height, width); }
            else if (shapeType == 3) { newShape = new Square(height); }
            else { newShape = new Rectangle(0, 0); }
            shapes[i] = newShape;
        }
        return shapes;
    }
}

abstract class GeometricShape {
    protected int area;
    public int Height { get; set; }
    public int Width { get; set; }
    public int Area { get { this.ComputeArea(); return this.area; } }

    protected abstract void ComputeArea();
}

class Rectangle : GeometricShape {
    public Rectangle(int height, int width) {
        this.Height = height;
        this.Width = width;
    }
    protected override void ComputeArea() {
        base.area = this.Height * this.Width;
    }

    public override string ToString() {
        return String.Format("A rectangle with the dimensions {0:n0} X {1:n0} has an area of {2:n0}", this.Height, this.Width, this.Area);
    }
}

class Triangle : GeometricShape {
    public Triangle(int height, int width) {
        this.Height = height;
        this.Width = width;
    }

    protected override void ComputeArea() {
        base.area = (int) (0.5 * this.Height * this.Width);
    }

    public override string ToString() {
        return String.Format("A triangle with the dimensions {0:n0} X {1:n0} has an area of {2:n0}", this.Height, this.Width, this.Area);
    }
}

class Square : Rectangle {
    public Square(int width, int height) : base(height, width) {
        // Write("Square width: {0,3}, square height: {1,3}", width, height);
        if (width != height) {
            // Write(", Width + Height: {0,3}", (width+height));
            int temp = ((width + height) / 2);
            // WriteLine(", Square temp: {0,3}", temp);
            this.Width = temp;
            this.Height = temp;
        }
    }

    public Square(int sideLength) : base(sideLength, sideLength) { }

    public override string ToString() {
        return String.Format("A square with the dimensions {0:n0} X {1:n0} has an area of {2:n0}", this.Height, this.Width, this.Area);
    }
}