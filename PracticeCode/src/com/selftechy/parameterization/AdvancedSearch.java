package com.selftechy.parameterization;

import java.io.File;
import org.junit.*;
import org.junit.runner.RunWith;
import org.junit.runners.BlockJUnit4ClassRunner;
import org.openqa.selenium.*;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.remote.RemoteWebDriver;

import junit.framework.TestCase;

@RunWith(BlockJUnit4ClassRunner.class)
public class AdvancedSearch extends TestCase {
	private static ChromeDriverService service;
	  private WebDriver driver;

	  @BeforeClass
	  public static void createAndStartService() throws Exception {
	    service = new ChromeDriverService.Builder()
	        .usingDriverExecutable(new File("E:/dev/homedev/Tools/selenium-2.46.0/chromedriver_win32/chromedriver.exe"))
	        .usingAnyFreePort()
	        .build();
	    service.start();
	  }

	  @AfterClass
	  public static void createAndStopService() throws Exception{
	    service.stop();
	  }

	  @Before
	  public void createDriver() throws Exception{
	    driver = new RemoteWebDriver(service.getUrl(),
	        DesiredCapabilities.chrome());
	  }

	  @After
	  public void quitDriver() throws Exception {
	    driver.quit();
	  }

	@Test
	public void testAdvancedSearch() throws Exception {
		/*selenium.open("http://www.google.co.za/advanced_search");
		//selenium.click("link=Advanced search");
		selenium.waitForPageToLoad("30000");
		selenium.type("as_q", "selftechy, selenium, eclipse");
		//selenium.select("num", "label=20 results");
		selenium.click("//input[@value='Advanced Search']");
		selenium.waitForPageToLoad("30000");*/
		//System.setProperty("webdriver.chrome.driver", "E:/dev/homedev/Tools/selenium-2.46.0/chromedriver_win32/chromedriver.exe");
		
		
		driver.get("http://www.google.co.zax");
		Thread.sleep(5000);  // Let the user actually see something!
		WebElement searchBox = driver.findElement(By.name("q"));
		searchBox.sendKeys("Cheese festival");
		searchBox.submit();
		Thread.sleep(5000);  // Let the user actually see something!
		
	}
}