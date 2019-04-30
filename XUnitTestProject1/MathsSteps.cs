using System;
using TechTalk.SpecFlow;

namespace XUnitTestProject1
{
    [Binding]
    public class MathsSteps
    {
        [Given(@"x = (.*)")]
        public void GivenX(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"y = (.*)")]
        public void GivenY(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"x \+ y")]
        public void WhenXY()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"(.*)")]
        public void Then(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
