using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowTAF.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private Helper helper;
        private string[] tags;



        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
           // helper = new Helper(ScenarioContext.Current);
            //ScenarioContext.Current["@tag1"] = helper;
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
           // helper.Cleanup();
        }
    }
}