using System;
using TechTalk.SpecFlow;

namespace BankTestGherkin.Steps
{
    [Binding]
    public class BankingSteps
    {
        [Given(@"account Omni is selected")]
        public void GivenAccountOmniIsSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"customer is not false")]
        public void GivenCustomerIsNotFalse()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"customer is true")]
        public void GivenCustomerIsTrue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I transfer (.*) to Lifestyle")]
        public void WhenITransferToLifestyle(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"(.*) transferred is more than (.*)")]
        public void WhenTransferredIsMoreThan(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Lifestyle is transferred to")]
        public void ThenLifestyleIsTransferredTo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the account is charged a (.*)")]
        public void ThenTheAccountIsChargedA(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the (.*) should be withdrawn from the (.*)")]
        public void ThenTheShouldBeWithdrawnFromThe(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
