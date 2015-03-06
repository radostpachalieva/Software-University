import java.util.ArrayList;
import java.util.Scanner;


public class StringInputLineToIntegerArray {

	public static void main(String[] args) {
		
		// (3) (22) (-18) (55) (44) (3) (21)
		// 4

		// Read and parse the input numbers
		Scanner scn = new Scanner(System.in);
		String stringInput = scn.nextLine();
		
		String[] stringArray = stringInput.split("[ ()]+");
		int[] intArray = new int[stringArray.length-1];
		for (int i = 0; i < intArray.length; i++) {
			intArray[i] = Integer.parseInt(stringArray[i]);
		}
		
		// =========================================

		Scanner input = new Scanner(System.in);
		String[] nums = input.nextLine().split("\\D+");
		
		ArrayList<Integer> numbers = new ArrayList<Integer>();
		
		for (int i = 0; i < nums.length; i++) {
			if (!nums[i].equals("")) {
				numbers.add(Integer.parseInt(nums[i]));
			}
		}

		for (int i : intArray) {
			System.out.println(i);
		}
		
	}

}
