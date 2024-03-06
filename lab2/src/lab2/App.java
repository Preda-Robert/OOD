package lab2;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

import lab2.builder.Builder;

public class App {
	public static void main(String[] args) {
		Builder sequenceBuilder = new Builder(15);
		try {
		      File myObj = new File("filename.txt");
		      Scanner scanner = new Scanner(myObj);
		      while (scanner.hasNextLine()) {
		        int command = scanner.nextInt();
		        if(command == 1) {
		        	int index = scanner.nextInt();
		        	sequenceBuilder.resize(index);
		        	sequenceBuilder.at(index);
		        }
		        else {
		        	int l = scanner.nextInt();
		        	int r = scanner.nextInt();
		        	sequenceBuilder.resize(r);
		        	sequenceBuilder.reverse(l, r);
		        }
		      }
		      scanner.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
	}

}
