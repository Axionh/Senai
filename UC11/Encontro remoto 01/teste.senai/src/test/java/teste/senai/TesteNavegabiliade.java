package teste.senai;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteNavegabiliade {

ChromeDriver driver; //driver do google chrome 
	
	// pré-teste
	@Before
	public void PreTeste() {
		System.setProperty("webdriver.chrome.driver", "C:\\Program Files (x86)\\chromedriver\\chromedriver.exe");
		this.driver = new ChromeDriver (); //abrir o navegador
		//maximizar o navegador
		driver.manage().window().maximize();		
		//ir até o site senai  https://informatica.sp.senai.br/
		driver.get("https://informatica.sp.senai.br/");
	}
 
	// teste  crtl space para puzar o import junit
	@Test
	public void Teste() {
		driver.findElement(By.id ("Busca1_txtFiltro")).sendKeys("Excel"); //pesquisa o termo excel 
//		driver.findElement(By.id ("Busca1_btnBusca")).click(); //clica na busca
		driver.findElement(By.id ("Busca1_txtFiltro")).sendKeys(Keys.ENTER); //clica na busca
		

	}

	// pós-teste
	@After
	public void PosTeste() {
		driver.quit();

	}

}
