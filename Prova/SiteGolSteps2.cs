using System;
using TechTalk.SpecFlow;

namespace Prova
{
    [Binding]
    public class SiteGolSteps2
    {
        [When(@"seleciono a data da ida um dia após o dia atual")]
        public void WhenSelecionoADataDaIdaUmDiaAposODiaAtual()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"seleciono a data de volta como (.*) de agosto")]
        public void WhenSelecionoADataDeVoltaComoDeAgosto(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
