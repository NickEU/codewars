package kyu6;

import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class ConvertStringToCamelCaseTest {
    private static final String EXPECTED_STEALTH_WARRIOR = "theStealthWarrior";

    @Test
    public void testSomeUnderscoreLowerStart() {
        String input = "the_Stealth_Warrior";
        System.out.println("input: " + input);
        assertEquals(EXPECTED_STEALTH_WARRIOR, ConvertStringToCamelCase.toCamelCase(input));
    }

    @Test
    public void testSomeDashLowerStart() {
        String input = "the-Stealth-Warrior";
        System.out.println("input: " + input);
        assertEquals(EXPECTED_STEALTH_WARRIOR, ConvertStringToCamelCase.toCamelCase(input));
    }

    @Test
    public void testEmptyString() {
        String input = "";
        System.out.println("input: " + input);
        assertEquals(input, ConvertStringToCamelCase.toCamelCase(input));
    }

    @Test
    public void testSingleChar() {
        String input = "n";
        System.out.println("input: " + input);
        assertEquals(input, ConvertStringToCamelCase.toCamelCase(input));
    }

    @Test
    public void testSingleCharUpperCase() {
        String input = "N";
        System.out.println("input: " + input);
        assertEquals(input, ConvertStringToCamelCase.toCamelCase(input));
    }
}

