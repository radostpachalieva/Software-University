import java.util.Arrays;
import java.util.Scanner;

public class _02_PossibleTriangles {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		String inputLine = input.nextLine();
		boolean resultFound = false;

		while (!inputLine.equals("End")) {

			String[] numbersString = inputLine.split("\\s+");

			double[] numbers = new double[3];

			for (int i = 0; i < numbers.length; i++) {
				numbers[i] = Double.parseDouble(numbersString[i]);
			}

			Arrays.sort(numbers);

			if (numbers[0] + numbers[1] > numbers[2]) {
				System.out.printf("%.2f+%.2f>%.2f%n", 
						numbers[0],	numbers[1], numbers[2]);
				resultFound = true;
			}

			inputLine = input.nextLine();
		}

		if (!resultFound) {
			System.out.println("No");
		}
		
	}
}
