package kyu6;

import java.util.Arrays;
import java.util.stream.Collectors;

public class AreSame {
    // https://www.codewars.com/kata/550498447451fbbd7600041c
    public static boolean comp(int[] nums, int[] squares) {
        if (nums == null || squares == null) {
            return false;
        }

        var numbers = Arrays.stream(nums)
            .boxed().collect(Collectors.groupingBy(
                Math::abs,
                Collectors.counting()));

        for (int num : squares) {
            double potentialSqrt = Math.sqrt(num);
            if (Math.floor(potentialSqrt) != potentialSqrt) {
                return false;
            }
            int sqRt = (int) potentialSqrt;
            if (numbers.get(sqRt) == null) {
                return false;
            }
            if (numbers.get(sqRt) > 1) {
                numbers.put(sqRt, numbers.get(sqRt) - 1);
            } else {
                numbers.remove(sqRt);
            }
        }

        return true;
    }
}
