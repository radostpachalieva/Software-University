import java.util.Scanner;

public class _01_CountBeers {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		int totalBeers = 0;
		while (true) {
			String orderLine = input.nextLine();
			if (orderLine.equals("End")) {
				break;
			}
			String[] order = orderLine.split(" ");
			int beers = Integer.parseInt(order[0]);
			if (order[1].equals("stacks")) {
				beers *= 20;
			}
			totalBeers += beers;
		}
		System.out.printf("%d stacks + %d beers\n", totalBeers / 20,
				totalBeers % 20);

//		Scanner input = new Scanner(System.in);
//		String[] inputLine = input.nextLine().split("\\s+");
//		int countBeer = 0;
//
//		while (!inputLine[0].equals("End")) {
//
//			if (inputLine[1].equals("stacks")) {
//				countBeer += 20 * Integer.parseInt(inputLine[0]);
//			}
//
//			countBeer += Integer.parseInt(inputLine[0]);
//			inputLine = input.nextLine().split("\\s+");
//		}
//
//		int stacks = countBeer / 20;
//		countBeer = countBeer % 20;
//		System.out.printf("%d stacks + %d beers", stacks, countBeer);

	}

}
