package TesteEPlayers;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class testesenaiEplayers {
	ChromeDriver driver; // driver do google chrome

	// pré-teste
	@Before
	public void PreTeste() {
		System.setProperty("webdriver.chrome.driver", "C:\\Program Files (x86)\\chromedriver\\chromedriver.exe");
		driver = new ChromeDriver();
		driver.manage().window().maximize();
	}

	@Test
	public void testeNavegador() {
		driver.get("http://localhost:4200/");
		driver.findElement(By.xpath("//*[@id=\"menu\"]/a[2]")).click();

		// criar elements
		WebElement inputEmail = driver.findElement(By.id("usuario"));
		WebElement inputSenha = driver.findElement(By.id("senha"));
		WebElement inputSubmit = driver.findElement(By.xpath("/html/body/app-root/app-login/div/form/button[1]"));
		String[] listaEmails = { "jose@email.com", "eduardo@email.com", "email sem formato", "eduardo@email.com" };
		String[] listaSenhas = { "senhaum", "senhadois", "123", "12345678" };

		// tentativas de entrar
		for (int tentativas = 0; tentativas < listaSenhas.length; tentativas++) {
			try {
				// limpando os campos
				inputEmail.clear();
				inputSenha.clear();

				// preencher os campos
				inputEmail.sendKeys(listaEmails[tentativas]);
				inputSenha.sendKeys(listaSenhas[tentativas]);
				inputSubmit.click();

				Thread.sleep(3000);
				
			} catch (InterruptedException error) {
				error.printStackTrace();
			}
		}
	}
	@After 
	public void FinalizarTeste() {
		try {
			Thread.sleep(2000);
			driver.quit();
		}catch (Exception error) {
			error.printStackTrace();
		}
	}
}
