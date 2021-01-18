using EAAutoFramework.Base;
using CrossPlatformEATest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using EAEmployeeTest.Pages;

namespace CrossPlatformEATest.Steps
{
    [Binding]
    public class RegisterUserSteps : BaseStep
    {

        //Context injection
        private readonly ParallelConfig _parallelConfig;

        public RegisterUserSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }
        [When(@"I enter UserName, Password, ConfirmPassword, Email")]
        public void WhenIEnterUserNamePasswordConfirmPasswordEmail(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _parallelConfig.CurrentPage.As<RegisterPage>().FillRegisterData(data.UserName, data.Password, data.ConfirmPassword, data.Email);
        }
    }
}
