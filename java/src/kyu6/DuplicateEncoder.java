package kyu6;

import java.util.function.Function;
import java.util.stream.Collectors;

public class DuplicateEncoder {
    static String encode(String word) {
        String lwrCaseWord = word.toLowerCase();
        var charCounts = lwrCaseWord.chars()
            .mapToObj(c -> (char) c)
            .collect(Collectors.groupingBy(
                Function.identity(),
                Collectors.counting()));
        return lwrCaseWord.chars()
            .mapToObj(c -> charCounts.get((char) c) > 1 ? ")" : "(")
            .collect(Collectors.joining());
    }
}
