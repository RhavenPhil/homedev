import java.util.ArrayList;

import org.junit.*;

import static org.junit.Assert.*;

import org.junit.runner.RunWith;

import junitparams.*;
import static junitparams.JUnitParamsRunner.$;

@RunWith(JUnitParamsRunner.class)
public class paramsTests {
	
	static ParameterList myTests = new ParameterList();
	
	static ArrayList<String> tests = myTests.arrayListParams();
	
	@Before
	public void setUp() throws Exception {
		//System.out.println(tests);
	}
	  
	@Test
	@Parameters (method = "provideParameters")
	public void compareInput(String myTest) throws Exception {
		assertEquals("Test Result", myTest);
	}
	  
	public Object[] provideParameters() {
		Object jone = new Object();
		Object [] jones = (Object[]) new Object();
		
		jone = $(tests.get(0));
		jones = $((jone),(jone));
		return $(jones);
	}
	  
	@After
	public void tearDown() throws Exception {
	
	}
}

class ParameterList{
	
	public ArrayList<String> arrayListParams ()
	{
		ArrayList<String> testList = new ArrayList<String>();
		
		testList.add(0, "My");
		testList.add(1, "baby");
		testList.add(2, "Test Result");
		return testList;
	}
}
