using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlaUI.UIA3;
using FlaUI.Core;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;

namespace FlaUiTests
{
    [TestClass]
    public class StudentHelperTests
    {
        [TestMethod]
        public void TestRegister()
        {
            var application = FlaUI.Core.Application.Launch(@"C:\Users\Vlad\Documents\GitHub\CSharp-Windows-Form-Student-Database-Application\LoginForm\LoginForm\bin\Debug\LoginForm.exe");
            
            var mainWindow = application.GetMainWindow(new UIA3Automation());

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            mainWindow.FindFirstDescendant(cf.ByAutomationId("QuitMenuBTN")).AsButton().Click();
            /*
            mainWindow.FindFirstDescendant(cf.ByAutomationId("RegisterMenuBTN")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByAutomationId("usernameRegister")).AsTextBox().Enter("UName");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("passwordRegister")).AsTextBox().Enter("Pwd");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("confirmPasswordRegister")).AsTextBox().Enter("Pwd");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("emailRegister")).AsTextBox().Enter("Email");
            mainWindow.FindFirstDescendant(cf.ByAutomationId("register")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByName("OK")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByAutomationId("mainMenu")).AsButton().Click();
            mainWindow.FindFirstDescendant(cf.ByAutomationId("QuitMenuBTN")).AsButton().Click();
            */

        }
    }
}
