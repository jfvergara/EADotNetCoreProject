using EAAutoFramework.Base;
using OpenQA.Selenium;
using EAAutoFramework.Extensions;

namespace EAEmployeeTest.Pages
{
    class RegisterPage : BasePage
    {
        public RegisterPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        IWebElement txtUserName => _parallelConfig.Driver.FindById("UserName");
        IWebElement txtPassword => _parallelConfig.Driver.FindById("Password");
        IWebElement txtConfirmPassword => _parallelConfig.Driver.FindById("ConfirmPassword");
        IWebElement txtEmail => _parallelConfig.Driver.FindById("Email");
        IWebElement btnRegister => _parallelConfig.Driver.FindElementByCssSelector(".btn");

        public void FillRegisterData(string userName, string password, string confirmPassword, string email)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            txtConfirmPassword.SendKeys(confirmPassword);
            txtEmail.SendKeys(email);
        }

        public HomePage ClickRegisterButton()
        {
            btnRegister.Submit();
            return new HomePage(_parallelConfig);
        }
    }
}
