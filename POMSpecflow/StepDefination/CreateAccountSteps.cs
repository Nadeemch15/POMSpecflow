using POMSpecflow.PageObject;
using System;
using TechTalk.SpecFlow;

namespace POMSpecflow.StepDefination
{
    [Binding]
    public class CreateAccountFeatureSteps
    {
        CreateAccountPage CRPage;
        public CreateAccountFeatureSteps()
        {
            CRPage = new CreateAccountPage();
        }
        [Given(@"Client is on the website")]
        public void GivenClientIsOnTheWebsite()
        {
            CRPage.NavigateToPage();
        }

        [Given(@"client enter the email ""(.*)""")]
        public void GivenClientEnterTheEmail(string email)
        {
            CRPage.Email(email);
        }


        

               
        [When(@"client click the Create an account button")]
        public void WhenClientClickTheCreateAnAccountButton()
        {
            CRPage.Createbtn();
        }

        [Then(@"Client navigate to create account form")]
        public void ThenClientNavigateToCreateAccountForm()
        {
            CRPage.PageHead();
        }

    }
}
