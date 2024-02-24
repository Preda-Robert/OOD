package lab1;

public class Main {

	public static void main(String[] args) {
		LandOwner landOwner = new LandOwner();

        Plot square = new Square(10.0);
        Plot rectangle = new Rectangle(24.0, 5.0);
        Plot triangle = new Triangle(6.0, 8.0);
        Plot trapezoid = new Trapezoid(4.0, 7.0, 5.0);
        Plot circle = new Circle(3.0);
        
        landOwner.addPlot(square);
        landOwner.addPlot(rectangle);
        landOwner.addPlot(triangle);
        landOwner.addPlot(trapezoid);
        //landOwner.addPlot(circle);

        double totalArea = landOwner.calculateTotalArea();
        System.out.println("Total area of all plots: " + totalArea);
        
        double totalTax = landOwner.calculateTotalTax();
        System.out.println("Total tax: " + totalTax + " RON");
	}

}
