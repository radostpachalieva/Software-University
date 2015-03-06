import java.util.Scanner;

public class _01_VideoDurations {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		String times = input.next();

		int hour = 0;
		int minute = 0;
		int totalHours = 0;
		int totalMinutes = 0;

		while (times.compareTo("End") != 0) {

			String[] timesSplit = times.split(":");
			hour = Integer.parseInt(timesSplit[0]);
			minute = Integer.parseInt(timesSplit[1]);

			totalMinutes += (hour * 60) + minute;
			times = input.next();

		}
		totalHours = totalMinutes / 60;
		totalMinutes = totalMinutes - (totalHours * 60);
		System.out.printf("%d:%02d\n", totalHours, totalMinutes);
		
		
	}

}
