import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;


public class ArrayListBigDecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int len = input.nextInt();
		ArrayList<BigDecimal> numbers = new ArrayList<BigDecimal>();
		for (int i = 0; i < len; i++) {
			numbers.add(input.nextBigDecimal());
		}

		Collections.sort(numbers);
		

//		Arrays.sort(inputArray);
//		Collections.reverse(Arrays.asList(inputArray));
		
		// Reverse!!
		// BigDecimal[] inputArrayRev = new BigDecimal[number];
		// for (int i = inputArray.length - 1; i >= 0; i--) {
		// // System.out.println(inputArray[i]);
		// inputArrayRev[i] = inputArray[i];
		// }
		
	}

}
