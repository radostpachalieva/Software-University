import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Locale;
import java.util.Scanner;

public class _02_ThreeLargestNumbers {

	public static void main(String[] args) {

		// Locale.setDefault(Locale.ROOT);
		Scanner scn = new Scanner(System.in);
		int number = scn.nextInt();
		// scn.nextLine();

		BigDecimal[] inputArray = new BigDecimal[number];

		for (int i = 0; i < inputArray.length; i++) {
			inputArray[i] = scn.nextBigDecimal();
		}

		Arrays.sort(inputArray);
		Collections.reverse(Arrays.asList(inputArray));
		
		
		if (number>=3) {
			for (int i = 0; i < 3; i++) {
				System.out.println(inputArray[i].toPlainString());
			}
		} else {
			for (int i = 0; i < number; i++) {
				System.out.println(inputArray[i].toPlainString());
			}
		}
				
		
//		
//		for (int i = inputArray.length - 1; i >= 0 && count > 0; i--, count--) {
//			System.out.println(inputArray[i].toPlainString());
//		}
		
		// BigDecimal[] inputArrayRev = new BigDecimal[number];
		// for (int i = inputArray.length - 1; i >= 0; i--) {
		// // System.out.println(inputArray[i]);
		// inputArrayRev[i] = inputArray[i];
		// }

//		int count = 3;
//		for (int i = inputArray.length - 1; i >= 0 && count > 0; i--, count--) {
//			System.out.println(inputArray[i].toPlainString());
//		}



	}

}
