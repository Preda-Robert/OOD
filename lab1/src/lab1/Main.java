package lab1;

public class Main {

	public static void main(String[] args) {
		LandOwner landOwner = new LandOwner();

        Plot square = new Square(5.0);
        Plot rectangle = new Rectangle(3.0, 4.0);
        Plot triangle = new Triangle(6.0, 8.0);
        Plot trapezoid = new Trapezoid(4.0, 7.0, 5.0);

        landOwner.addPlot(square);
        landOwner.addPlot(rectangle);
        landOwner.addPlot(triangle);
        landOwner.addPlot(trapezoid);

        double totalArea = landOwner.calculateTotalArea();
        System.out.println("Total area of all plots: " + totalArea);
	}

}
