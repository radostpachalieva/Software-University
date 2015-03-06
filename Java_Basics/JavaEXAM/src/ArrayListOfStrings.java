import java.util.ArrayList;
import java.util.Scanner;


public class ArrayListOfStrings {

	public static void main(String[] args) {
		

		Scanner input = new Scanner(System.in);
		String data = input.nextLine();

		String[] cardValue = data.split("\\D+");
		ArrayList<Integer> cards = new ArrayList<Integer>();
		
		for (String card : cardValue) {
			if (!card.equals("")) {
				cards.add(Integer.parseInt(card));
			}
		}

	}

}
