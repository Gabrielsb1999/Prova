using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace Prova
{
    [Binding]
    public class SiteGolSteps
    {

        static Webdriver _driver = Webdriver.GetDriver();
        static IWebDriver driver = new ChromeDriver();

        [Given(@"que acesso o site ""(.*)""")]
        public void GivenQueAcessoOSite(string url)
        {
           
            _driver.Chrome(url);

        }
        
        [When(@"eu seleciono a origem como SDU")]
        public void WhenEuSelecionoAOrigemComoSDU()
        {
            driver.FindElement(By.Id("//input[@id='header-chosen-origin']")).SendKeys("Santos Dummont" + Keys.Enter);      
        }
        
        [When(@"seleciono o destino como GRU")]
        public void WhenSelecionoODestinoComoGRU()
        {
            driver.FindElement(By.Id("//input[@id='header-chosen-destiny']")).SendKeys("Guarulhos" + Keys.Enter);
        }

        [When(@"seleciono a data da ida um dia após o dia atual")]
        public void WhenSelecionoADataDaIdaUmDiaAposODiaAtual()
        {
            string diaIda = _driver.DiaDoMes();

            driver.FindElement(By.XPath("//input[@id='datepickerGo']")).Clear();

            driver.FindElement(By.XPath("//input[@id='datepickerGo']")).SendKeys(diaIda);
        }

        [When(@"seleciono a data de volta como (.*) de agosto")]
        public void WhenSelecionoADataDeVoltaComoDeAgosto()
        {
            driver.FindElement(By.XPath("//input[@id='datepickerBack']")).Clear();

            driver.FindElement(By.XPath("//input[@id='datepickerBack']")).SendKeys("15/08/2020");
        }

        [When(@"adiciono dois adultos")]
        public void WhenAdicionoDoisAdultos()
        {
            driver.FindElement(By.Id("number-adults")).Clear();

            driver.FindElement(By.Id("number-adults")).SendKeys("2");
        }


        [When(@"clico no botão Compre Aqui")]
        public void WhenClicoNoBotaoCompreAqui()
        {
            driver.FindElement(By.Id("btn-box-buy")).Click();
        }
        
        [Then(@"seleciono a Menor tarifa do dia para voo de ida e voo de volta")]
        public void ThenSelecionoAMenorTarifaDoDiaParaVooDeIdaEVooDeVolta()
        {
            
        }
    }
}
