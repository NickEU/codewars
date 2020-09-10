package kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class WhoLikesItTest {
    @Test
    public void staticTests() {
        assertEquals("no one likes this", WhoLikesIt.run());
        assertEquals("Peter likes this", WhoLikesIt.run("Peter"));
        assertEquals("Jacob and Alex like this", WhoLikesIt.run("Jacob", "Alex"));
        assertEquals("Max, John and Mark like this", WhoLikesIt.run("Max", "John", "Mark"));
        assertEquals("Alex, Jacob and 2 others like this", WhoLikesIt.run("Alex", "Jacob", "Mark", "Max"));
    }
}
