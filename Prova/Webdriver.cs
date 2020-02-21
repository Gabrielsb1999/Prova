using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
	class Webdriver
	{
		//Singleton
		private Webdriver() { }

		private static Webdriver Instancia;

		private IWebDriver _driver;

		public IWebDriver driver { get => _driver; set => _driver = value; }

		//construtor da instancia
		public static Webdriver GetDriver()
		{
			if (Instancia == null)
			{
				Instancia = new Webdriver();
			}
			return Instancia;
		}

		public Boolean Chrome(string url)
		{

			try
			{
				ChromeOptions options = new ChromeOptions();

				options.AddArguments("test-type");
				options.AddArguments("--incognito");
				options.AddArguments("--disable-gpu");
				options.AddArguments("--start-maximized");
				options.UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss;
				options.AddArguments("--disable-notifications");
				options.AddArguments("--disable-extensions");
				options.AddArguments("--disable-application-cache");
				options.AddExcludedArgument("enable-automation");
				options.AddExcludedArgument("ignore-certificate-errors");
				options.AddAdditionalCapability("useAutomationExtension", false);
				options.AddUserProfilePreference("credentials_enable_service", false);
				options.AddUserProfilePreference("profile.password_manager_enabled", false);

				driver = new ChromeDriver(options);
				driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

				driver.Navigate().GoToUrl(url);

				return true;
			}
			catch (WebDriverException)
			{
				return false;
			}
		}

		public string DiaDoMes()
		{
			try
			{
				var dt = DateTime.Today;
				dt.AddDays(1);

				return dt.ToString("d");

			}
			catch (Exception)
			{
				return null;
			}
		}

	}
}
