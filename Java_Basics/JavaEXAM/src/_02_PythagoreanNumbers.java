import java.util.HashSet;
import java.util.Scanner;

public class _02_PythagoreanNumbers {

	public static void main(String[] args) {
		
		Scanner scn = new Scanner(System.in);
		int numLenght = scn.nextInt();
		int[] numbersArr = new int[numLenght];

		boolean found = false;
		// To read the numbers
		for (int i = 0; i < numbersArr.length; i++) {

			// Full the numbers in every line in the Array!!
			numbersArr[i] = scn.nextInt();
		}
		
		// ====================================================================================
		
		HashSet<Integer> squares = new HashSet<>();
		for (int num : numbersArr) {
			squares.add(num * num);
		}
		int count = 0;
		for (int a : numbersArr) {
			for (int b : numbersArr) {
				int cSquare = a*a + b*b; 
				if (a <= b && squares.contains(cSquare)) {
					int c = (int)Math.sqrt(cSquare);
					System.out.printf(
						"%d*%d + %d*%d = %d*%d\n",
						a, a, b, b, c, c);
					count++;
				}
			}
		}
		if (count == 0) {
			System.out.println("No");
		}
		// ====================================================================================
		
		
//		// Checking
//		for (int i = 0; i < numbersArr.length; i++) {
//			int a = numbersArr[i];
//			for (int j = 0; j < numbersArr.length; j++) {
//				int b = numbersArr[j];
//				
//				if (a <= b) {
//					for (int k = 0; k < numbersArr.length; k++) {
//						int c = numbersArr[k];
//								
//						if (a*a + b*b == c*c) {
//							System.out.printf("%d*%d + %d*%d = %d*%d",
//									a, a, b, b ,c ,c);
//							found = true;
//							System.out.println();
//						}		
//					}
//				}
//			}
//		}
//		if (!found) {
//			System.out.println("No");
//		}
//=========================================================================
	}
}
