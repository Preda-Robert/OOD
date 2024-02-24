package lab1;

abstract class Plot {
    abstract double area();
}

class Square extends Plot {
    private double side;

    Square(double side) {
        this.side = side;
    }

    
    double area() {
        return side * side;
    }
}

class Rectangle extends Plot {
    private double length;
    private double width;

    Rectangle(double length, double width) {
        this.length = length;
        this.width = width;
    }

    
    double area() {
        return length * width;
    }
}

class Triangle extends Plot {
    private double base;
    private double height;

    Triangle(double base, double height) {
        this.base = base;
        this.height = height;
    }

    
    double area() {
        return 0.5 * base * height;
    }
}

class Trapezoid extends Plot {
    private double base1;
    private double base2;
    private double height;

    Trapezoid(double base1, double base2, double height) {
        this.base1 = base1;
        this.base2 = base2;
        this.height = height;
    }

    
    double area() {
        return 0.5 * (base1 + base2) * height;
    }
}
