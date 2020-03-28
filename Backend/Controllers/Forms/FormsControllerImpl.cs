﻿using DesktopApp.Forms.LoginForm;
using DesktopApp.Forms.RegistrationForm;

namespace DesktopApp.Backend.Controllers.Forms
{
    public class FormsControllerImpl : FormsController
    {
        private static FormsController formsController = new FormsControllerImpl();
        private MainForm.MainForm mainForm;

        public static FormsController GetInstance()
        {
            return formsController;
        }

        private FormsControllerImpl() { }

        public void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public void OpenRegitrationForm()
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        public MainForm.MainForm GetMainForm()
        {
            if (mainForm == null)
            {
                mainForm = new MainForm.MainForm();
            }
            return mainForm;
        }
    }
}