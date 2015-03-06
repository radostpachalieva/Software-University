import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class _04_Orders {

	public static void main(String[] args) {

		// 8
		// steve 8 apples
		// maria 3 bananas
		// kiro 3 bananas
		// kiro 9 apples
		// maria 2 apples
		// steve 4 apples
		// kiro 1 bananas
		// kiro 1 apples

		// apples: kiro 10, maria 2, steve 12
		// bananas: kiro 4, maria 3

		// Process the input orders and put them in a map
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();

		LinkedHashMap<String, TreeMap<String, Integer>> orders = new LinkedHashMap<>();

		for (int i = 0; i < n; i++) {
			String customer = input.next();
			int amount = input.nextInt();
			String product = input.next();

			if (!orders.containsKey(product)) {
				orders.put(product, new TreeMap<String, Integer>());
			}

			TreeMap<String, Integer> amounts = orders.get(product);
			int oldAmount = 0;

			if (amounts.containsKey(customer)) {
				oldAmount = amounts.get(customer);
			}
			amounts.put(customer, oldAmount + amount);
		}

		// Print the products and their customers and amounts
		
		for (String product : orders.keySet()) {
			
			System.out.print(product + ": ");
			
			TreeMap<String, Integer> amounts = orders.get(product);
			boolean first = true;
			for (Map.Entry<String, Integer> pair : amounts.entrySet()) {
				if (!first) {
					System.out.print(", ");
				}
				first = false;
				String customer = pair.getKey();
				int amount = pair.getValue();
				System.out.print(customer + " " + amount);
			}
			System.out.println();

		}

	}

}
