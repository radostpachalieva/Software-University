import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04_OfficeStuff {

	public static void main(String[] args) {
		
//		7
//		|SoftUni - 600 - paper|
//		|Vivacom - 600 - pen|
//		|XS - 20 - chair|
//		|Vivacom - 200 - chair|
//		|SoftUni - 40 - chair|
//		|XS - 40 - chair|
//		|SoftUni - 1 - printer|
		
//		SoftUni: paper-600, chair-40, printer-1
//		Vivacom: pen-600, chair-200
//		XS: chair-60

		Scanner scn = new Scanner(System.in);

		TreeMap<String, LinkedHashMap<String, Integer>> output = new TreeMap<String, LinkedHashMap<String, Integer>>();

		int n = Integer.parseInt(scn.nextLine());

		for (int i = 0; i < n - 1; i++) {
			String[] input = scn.nextLine().split(" - ");

			String company = input[0].substring(1, input[0].length());
			int broika = Integer.parseInt(input[1]);
			String product = input[2].substring(0, input[2].length() - 1);
			//System.out.println();

			if (!output.containsKey(company)) { // Ако output не съдържа такъв company.. KEY!!!
				output.put(company, new LinkedHashMap<String, Integer>()); // put в output ново company с new LinkedHashMap<String, Integer>()

			} else {

				if (!output.get(company).containsKey(product)) { // Ако вече има такъв ключ company, ...KEY!
					output.get(company).put(product, broika); // get it и put негови атрибути.
					
				} else {
					int currentBroika = output.get(company).get(product); // Ако вече и това е направено, вземи от output .. company and product
					currentBroika += broika;								// ?! Добрее събери бройката на съответния company и product с настоящата
					output.get(company).put(product, currentBroika);	// И направи така, че в output при get company, put product and currentBroika
				}
			}
		}

		for (String comp : output.keySet()) {

			System.out.printf("%s: ", comp);
			int indexCount = 1;
	
			}
			System.out.println();
			// scn.nextLine();
		}
}
