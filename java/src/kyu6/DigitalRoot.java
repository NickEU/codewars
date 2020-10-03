package kyu6;

public class DigitalRoot {
    public static int digital_root(int n) {
        var digits = String.valueOf(n);
        int sum = 0;
        for(int i = 0; i < digits.length(); i++) {
            int digit = Integer.parseInt(String.valueOf(digits.charAt(i)));
            sum += digit;
        }

        return sum > 9 ? digital_root(sum) : sum;
    }
}
