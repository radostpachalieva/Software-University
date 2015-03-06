import java.util.Arrays;
import java.util.Scanner;
// [3 x 3] [3 x 2] [4 x 3] [1 x 4] [5 x 3] [3 x 1]


public class _03_Largest3Rectangles {

	public static void main(String[] args) {

		Scanner scn = new Scanner(System.in);
		String stringInput = scn.nextLine();
		
		stringInput = stringInput.replaceAll("[^\\d]+", " ");
		//System.out.println(stringInput);
		
		// Split and parse!!!! String to Integer!
		String[] stringNumbres = stringInput.split(" ");
		int[] intArr = new int[stringNumbres.length - 1];	
		int[] areas = new int[intArr.length /2];

		
		for (int i = 1; i < stringNumbres.length; i++) { //!!!! 1 
			intArr[i - 1] = Integer.parseInt(stringNumbres[i]);
		}
		
		for (int i = 0, g = 0 ; i < areas.length; i++, g +=2) {
			areas[i] = intArr[g] * intArr[g+1];
		}
		

		int maxArea = Integer.MIN_VALUE;
		for (int i = 0; i < areas.length - 2; i++) {
			int sumAreas = areas[i] + areas[i+1] + areas[i+2];
			
			if (sumAreas>maxArea) {
				maxArea = sumAreas;
			}
		}
		System.out.println(maxArea);
	}
	
}
