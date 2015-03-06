import java.util.Scanner;

public class _01_MirrorNumbers {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);

		int len = scn.nextInt();
		int[] numbers = new int[len];
		
		for (int i = 0; i < len; i++) {
			numbers[i] = scn.nextInt();
		}
		boolean resultFound = false;

		for (int i = 0; i < numbers.length - 1; i++) {
			for (int j = i + 1; j < numbers.length; j++) {
				String numberOne = "" + numbers[i];
				String revercedNum = new StringBuffer("" + numbers[j]).reverse().toString();
				
				if (numberOne.equals(revercedNum)) {
					resultFound = true;
					System.out.println(numbers[i] + "<!>" + numbers[j]);
					
				}
			}
		}
		if (!resultFound)
			System.out.println("No");
	}
}
