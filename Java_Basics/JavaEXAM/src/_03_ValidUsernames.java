import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _03_ValidUsernames {

	public static void main(String[] args) {
		
//		ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref
//		wfsdg
//		ds2c_vbg
		
		Scanner input = new Scanner(System.in);
		String[] notValidatedDate = input.nextLine().split("[^a-zA-Z0-9_]+");
		ArrayList<String> data = new ArrayList<String>();
		
		for (String username : notValidatedDate) {
			boolean correntSize = username.length() >= 3 && username.length() <= 25;
			
			String user = username.toLowerCase();
			if (correntSize && user.charAt(0) >= 'a' && user.charAt(0) <= 'z') {
				data.add(username);
				// System.out.println(username);
			}
		}
		// Best sum  === Print at the console the 2 consecutive valid usernames 
		// with the biggest sum of their lengths each on a separate
		int bestIndex = 0;
		int maxLenght = 0;
		for (int i = 0; i < data.size(); i++) {
			for (int j = i; j < data.size() - 1; j++) {
				int currentLenght = data.get(j).length() + data.get(j + 1).length();
				
				if (currentLenght > maxLenght) {
					maxLenght = currentLenght;
					bestIndex = j;
				}
			}
		}
		System.out.println(data.get(bestIndex));
		System.out.println(data.get(bestIndex + 1));
	}

	//
	//
	// public static void main(String[] args) {
	//
	// Scanner input = new Scanner(System.in);
	// String inputLine = input.nextLine();
	//
	// inputLine = inputLine.replace("/", " ");
	// inputLine = inputLine.replace("\\", " ");
	// inputLine = inputLine.replace("(", " ");
	// inputLine = inputLine.replace(")", " ");
	//
	// String[] usernames = inputLine.split("\\s+");
	//
	// List<String> validUser = new ArrayList<String>();
	// for (String user : usernames) {
	// if (user.matches("[A-Za-z0-9_]{3,25}") &&
	// user.matches("[A-Za-z0-9_](.*)")) {
	//
	// validUser.add(user);
	// }
	// }
	//
	// int maxLength = 0;
	// String[] output = new String[2];
	//
	//
	// for (int i = 0; i < validUser.size()-1; i++) {
	//
	// String strA = validUser.get(i);
	// String strB = validUser.get(i+1);
	// int lenghtA = strA.length();
	// int lenghtB = strB.length();
	//
	// if (maxLength<lenghtA+lenghtB) {
	// maxLength = lenghtA+lenghtB;
	// output[0] = strA;
	// output[1] = strB;
	// }
	// }
	//
	// System.out.printf("%s\n%s", output[0], output[1]);
	// }
}
