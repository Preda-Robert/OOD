package lab1;

import java.util.ArrayList;

public class LandOwner {
	private ArrayList<Plot> plots;

    public LandOwner() {
        plots = new ArrayList<>();
    }

    public void addPlot(Plot plot) {
        plots.add(plot);
    }

    public void removePlot(Plot plot) {
        plots.remove(plot);
    }

    public double calculateTotalArea() {
        double totalArea = 0;
        for (Plot plot : plots) {
            totalArea += plot.area();
        }
        return totalArea;
    }
    
    public double calculateTotalTax() {
        double totalArea = calculateTotalArea();
        return totalArea * 0.01;
    }
}
