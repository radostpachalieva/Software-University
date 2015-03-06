
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class HashMapEx {

	public static void main(String[] args) {
		

 
		Scanner input = new Scanner(System.in);
		String[] data = input.nextLine().toLowerCase().split("\\W+");
		TreeMap<String, Integer> words = new TreeMap<String, Integer>();
		for (String word : data) {
			if (words.containsKey(word)) {
				words.put(word, words.get(word) + 1);
				
			} else {
				words.put(word, 1);
			}
		}
		
//		
//		HashMap<String, ArrayList<Integer>> grades = new HashMap<>();
//		grades.put("Peter", new ArrayList<>(Arrays.asList(5)));
//		grades.put("George", new ArrayList<>(Arrays.asList(5, 5, 6)));
//		grades.put("Maria", new ArrayList<>(Arrays.asList(5, 4, 4)));
//		grades.get("Peter").add(6);
//		grades.get("George").add(6);
//		
//		// print hashmap
//		for (String key : grades.keySet()) {
//			System.out.println("" + key + " -> " + grades.get(key));
//		}
//		
//		System.out.println("---------------------------------------");
//		
//		String[] words = { 
//				"yes", "hi", "hello", "hi", "welcome", "yes", "yes",
//				"welcome", "hi", "yes", "hello", "yes"
//			};
//			
//			Map<String, Integer> wordsCount = 
//					new HashMap<String, Integer>();
//			for (String word : words) {
//				Integer count = wordsCount.get(word);
//				if (count == null) {
//					count = 0; 
//				}
//				wordsCount.put(word, count+1);
//			}
//			
//			System.out.println(wordsCount);
//			
//			for (String word : wordsCount.keySet()) {
//				int count = wordsCount.get(word);
//				System.out.printf("%s -> %d times\n", word, count);
//			}		
//		
//		

	}

}
