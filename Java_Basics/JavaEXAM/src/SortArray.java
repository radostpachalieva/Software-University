import java.util.Arrays;
import java.util.Scanner;


public class SortArray {

	public static void main(String[] args) {
		
		Scanner scn = new Scanner(System.in);
		int n = scn.nextInt();
		scn.nextLine();
		String[] lines = new String[n];
		
		for (int i = 0; i < n; i++) {
			lines[i] = scn.nextLine();			
		}
		
		Arrays.sort(lines);
		
		for (int i = 0; i < lines.length; i++) {
			System.out.println(lines[i]);
		}

	}

}
