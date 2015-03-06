import java.util.ArrayList;
import java.util.Scanner;

public class _02_SumCards {

	public static void main(String[] args) {

		// 2C 2H 2D AS 10H 10C 2S KD
		// 83

		// 2 -> 2, 3 -> 3, 4 -> 4, 5 -> 5, 6 -> 6, 7 -> 7, 8 -> 8,
		// 9 -> 9, 10 -> 10, J -> 12, Q -> 13, K -> 14, A -> 15

		Scanner input = new Scanner(System.in);
		String data = input.nextLine();
		data = data.replaceAll("J", "12");
		data = data.replaceAll("Q", "13");
		data = data.replaceAll("K", "14");
		data = data.replaceAll("A", "15");
		
		String[] cardValue = data.split("\\D+");
		ArrayList<Integer> cards = new ArrayList<Integer>();
		
		for (String card : cardValue) {
			if (!card.equals("")) {
				cards.add(Integer.parseInt(card));
			}
		}
		
		int sum = 0;
		for (int i = 0; i < cards.size(); i++) {
			int currentSum = cards.get(i);
			int count = 1;
			
			if (i < cards.size() - 1) {
				while (cards.get(i) == cards.get(i + 1)) {
					count++;
					i++;
					if (i == cards.size() - 1) {
						break;
					}
				}
				
				if (count != 1) {
					sum += currentSum * count * 2;
				} else {
					sum += currentSum;
				}
				
			} else {
				sum += currentSum;
			}
		}
		System.out.println(sum);
	}

	// ==========================================================================
	//
	// Scanner input = new Scanner(System.in);
	// String cardsSequence = input.nextLine();
	// String[] cards = cardsSequence.split(" ");
	//
	// int sum = 0;
	// int prevValue = -1;
	// int count = 0;
	//
	// for (String card : cards) {
	// int value = getCardValue(card);
	//
	// if (value == prevValue) {
	// count++;
	// } else {
	// count = 1;
	// }
	//
	// sum = sum + value;
	// if (count == 2){
	// sum = sum + 2 * value;
	// }
	// if (count > 2) {
	// sum = sum + value;
	// }
	// prevValue = value;
	// }
	//
	// System.out.println(sum);
	// }

	private static int getCardValue(String card) {
		if (card.startsWith("2"))
			return 2;
		if (card.startsWith("3"))
			return 3;
		if (card.startsWith("4"))
			return 4;
		if (card.startsWith("5"))
			return 5;
		if (card.startsWith("6"))
			return 6;
		if (card.startsWith("7"))
			return 7;
		if (card.startsWith("8"))
			return 8;
		if (card.startsWith("9"))
			return 9;
		if (card.startsWith("10"))
			return 10;
		if (card.startsWith("J"))
			return 12;
		if (card.startsWith("Q"))
			return 13;
		if (card.startsWith("K"))
			return 14;
		if (card.startsWith("A"))
			return 15;
		throw new IllegalArgumentException("Invalid card: " + card);
	}

}
