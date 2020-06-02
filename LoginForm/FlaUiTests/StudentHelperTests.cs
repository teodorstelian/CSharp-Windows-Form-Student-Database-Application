using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlaUI.UIA3;
using FlaUI.Core;
using FlaUI.Core.Conditions;
using FlaUI.Core.AutomationElements;
using System.Threading;

namespace FlaUiTests
{
    [TestClass]
    public class StudentHelperTests
    {
        private Application _theApp;
        private UIA3Automation _automation;
        private Window _mainWindow, _registerWindow, _loginWindow, _appWindow;
        private ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
        private const int BigWaitTimeout = 3000;
        private const int SmallWaitTimeout = 1000;


        [TestMethod]
        public void T00_Launch_Quit()
        {
            /// First, we need to open the app
            _theApp = Application.Launch(@"C:\Users\Vlad\Documents\GitHub\CSharp-Windows-Form-Student-Database-Application\LoginForm\LoginForm\bin\Debug\LoginForm.exe");
            _automation = new UIA3Automation();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Main window
            _mainWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Click the Quit button
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("QuitMenuBTN")).AsButton().Click();
        }

        [TestMethod]
        public void T01_Launch_Register_Quit()
        {
            /// First, we need to open the app
            _theApp = Application.Launch(@"C:\Users\Vlad\Documents\GitHub\CSharp-Windows-Form-Student-Database-Application\LoginForm\LoginForm\bin\Debug\LoginForm.exe");
            _automation = new UIA3Automation();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Main window
            _mainWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Press the Register button
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("RegisterMenuBTN")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Registration window
            _registerWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Enter data into fields
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("usernameRegister")).AsTextBox().Enter("UName");
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("passwordRegister")).AsTextBox().Enter("Pwd");
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("confirmPasswordRegister")).AsTextBox().Enter("Pwd");
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("emailRegister")).AsTextBox().Enter("Email@yahoo.com");
            Thread.Sleep(SmallWaitTimeout);

            /// Click the register button
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("register")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Click the OK button
            _registerWindow.FindFirstDescendant(cf.ByName("OK")).AsButton().Click();

            /// Click the Main Menu button
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("mainMenu")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Main window
            _mainWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Click the Quit button
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("QuitMenuBTN")).AsButton().Click();
        }

        [TestMethod]
        public void T02_Launch_Login_Admin()
        {
            /// First, we need to open the app
            _theApp = Application.Launch(@"C:\Users\Vlad\Documents\GitHub\CSharp-Windows-Form-Student-Database-Application\LoginForm\LoginForm\bin\Debug\LoginForm.exe");
            _automation = new UIA3Automation();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Main window
            _mainWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Click the Login button
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("LoginMenuBTN")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Get Login window
            _loginWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Fill data
            _loginWindow.FindFirstDescendant(cf.ByAutomationId("emailLogin")).AsTextBox().Enter("admin");
            _loginWindow.FindFirstDescendant(cf.ByAutomationId("passwordLogin")).AsTextBox().Enter("admin");
            Thread.Sleep(SmallWaitTimeout);

            /// Click the Login button
            _loginWindow.FindFirstDescendant(cf.ByAutomationId("loginButton")).AsButton().Click();
            Thread.Sleep(BigWaitTimeout);

            /// Get App window
            _appWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Click the Quit button
            _appWindow.FindFirstDescendant(cf.ByAutomationId("QuitButton")).AsButton().Click();
        }

        [TestMethod]
        public void T03_Launch_Register_Login_Quit()
        {
            /// First, we need to open the app
            _theApp = Application.Launch(@"C:\Users\Vlad\Documents\GitHub\CSharp-Windows-Form-Student-Database-Application\LoginForm\LoginForm\bin\Debug\LoginForm.exe");
            _automation = new UIA3Automation();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Main window
            _mainWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Press the Register button
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("RegisterMenuBTN")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Registration window
            _registerWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Enter data into fields
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("usernameRegister")).AsTextBox().Enter("User");
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("passwordRegister")).AsTextBox().Enter("Passwd");
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("confirmPasswordRegister")).AsTextBox().Enter("Passwd");
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("emailRegister")).AsTextBox().Enter("asdf@yahoo.com");
            Thread.Sleep(SmallWaitTimeout);

            /// Click the register button
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("register")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Click the OK button
            _registerWindow.FindFirstDescendant(cf.ByName("OK")).AsButton().Click();

            /// Click the Main Menu button
            _registerWindow.FindFirstDescendant(cf.ByAutomationId("mainMenu")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Get the Main window
            _mainWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Click the Login button
            _mainWindow.FindFirstDescendant(cf.ByAutomationId("LoginMenuBTN")).AsButton().Click();
            Thread.Sleep(SmallWaitTimeout);

            /// Get Login window
            _loginWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Fill data
            _loginWindow.FindFirstDescendant(cf.ByAutomationId("emailLogin")).AsTextBox().Enter("asdf@yahoo.com");
            _loginWindow.FindFirstDescendant(cf.ByAutomationId("passwordLogin")).AsTextBox().Enter("Passwd");
            Thread.Sleep(SmallWaitTimeout);

            /// Click the Login button
            _loginWindow.FindFirstDescendant(cf.ByAutomationId("loginButton")).AsButton().Click();
            Thread.Sleep(BigWaitTimeout);

            /// Get App window
            _appWindow = _theApp.GetAllTopLevelWindows(_automation)[0];

            /// Click the Quit button
            _appWindow.FindFirstDescendant(cf.ByAutomationId("QuitButton")).AsButton().Click();
        }
    }
}
