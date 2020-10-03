package kyu6;

import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class DigitalRootTest {
    private static final String ERROR_MSG = "Wrong answer!";

    @Test
    public void Test1() {
        assertEquals(ERROR_MSG, 7, DigitalRoot.digital_root(16));
    }

    @Test
    public void Test2() {
        assertEquals( ERROR_MSG , 6, DigitalRoot.digital_root(456));
    }

    @Test
    public void Test3() {
        assertEquals( ERROR_MSG , 6, DigitalRoot.digital_root(942));
    }

    @Test
    public void Test4() {
        assertEquals( ERROR_MSG , 6, DigitalRoot.digital_root(132189));
    }

    @Test
    public void Test5() {
        assertEquals( ERROR_MSG , 2, DigitalRoot.digital_root(493193));
    }
}
