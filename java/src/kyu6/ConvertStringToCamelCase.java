package kyu6;

import java.util.Arrays;
import java.util.stream.Collectors;

public class ConvertStringToCamelCase {
    // Complete the method/function so that it converts dash/underscore delimited words
    // into camel casing. The first word within the output should be capitalized
    // only if the original word was capitalized (known as Upper Camel Case,
    // also often referred to as Pascal case).
    static String toCamelCase(String input) {
        var words = input.split("[_-]");
        return words[0] + Arrays.stream(words).skip(1)
            .map(s -> s.substring(0, 1).toUpperCase() + s.substring(1))
            .collect(Collectors.joining());
    }
}
