public class RandomBool {

	public static boolean getRandomBoolean() {
		return Math.random() < 0.5;
	}

	public static void main(String[] args) {
		System.out.println(getRandomBoolean());
	}

}
