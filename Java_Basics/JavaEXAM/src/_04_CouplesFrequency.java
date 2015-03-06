import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class _04_CouplesFrequency {

	public static void main(String[] args) {
		
		
		Scanner scn = new Scanner(System.in);
		String[] stringArray = scn.nextLine().split(" ");
		//int[] intArray = new int[stringArray.length];
	
		String[] couplesString = new String[stringArray.length - 1];
		
		for (int i = 0; i < couplesString.length; i++) {
			couplesString[i] = stringArray[i] + " " + stringArray[i + 1];
			//System.out.println(couplesString[i]);
		}

		Map<String, Integer> coupleCount = 
				new LinkedHashMap<String, Integer>();
		
		for (String couple : couplesString) {
			Integer count = coupleCount.get(couple);
			if (count == null) {
				count = 0; 
			}
			coupleCount.put(couple, count+1);
		}

		double arrayLenght = couplesString.length;
		for (String string : coupleCount.keySet()) {
			double percentage = (coupleCount.get(string) / arrayLenght) * 100;
			System.out.printf("%s -> %.2f%%\n", string, percentage);
			
		}
		
//		for (String couple : coupleCount.keySet()) {
//			int count = coupleCount.get(couple);
//			System.out.printf("%s -> %d times\n", couplesString, count);
//		}	
	}

}
