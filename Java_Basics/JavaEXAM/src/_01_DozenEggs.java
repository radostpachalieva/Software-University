import java.util.Scanner;

public class _01_DozenEggs {

	public static void main(String[] args) {

//		**1 dozens of 12 eggs
		
//		2 dozens
//		23 eggs
//		3 dozens
//		19 eggs
//		2 dozens
//		21 eggs
//		29 eggs
//		
//		14 dozens + 8 eggs
		
		// initialize variables
		Scanner str = new Scanner(System.in);
		int eggs = 0;
		int dozens = 0;

		for (int i = 0; i < 7; i++) {	// The number of input lines will be always 7.

			// read the input for actual "eggs" and "dozens"
			String input = str.nextLine();
			String[] currLine = input.split(" ");
			int currEggs = 0;

			// check the input if it is "eggs" or "dozens"
			if (currLine[1].toLowerCase().contains("dozen")) {
				currEggs = Integer.parseInt(currLine[0]) * 12;
			} else if (currLine[1].toLowerCase().contains("egg")) {
				currEggs = Integer.parseInt(currLine[0]);
			}

			// adding the input to total sum of "eggs"
			eggs += currEggs;
		}

		// calculating "eggs" and "dozens"
		dozens = eggs / 12;
		eggs = eggs % 12;

		System.out.println(dozens + " dozens + " + eggs + " eggs");

	}

}
