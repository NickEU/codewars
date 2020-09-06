package kyu6;

import java.util.stream.Collectors;

public class DuplicateEncoder {
    static String encode(String word){
        var count = word.toLowerCase().chars()
            .mapToObj(c -> (char) c)
            .collect(Collectors.toMap(
                c -> c,
                c -> 1,
                Integer::sum
            ));
        return word.toLowerCase().chars()
            .mapToObj(c -> count.get((char) c) > 1 ? ")" : "(")
            .collect(Collectors.joining());
    }
}
