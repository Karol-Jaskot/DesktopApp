﻿using System.Windows.Forms;

namespace DesktopApp.Backend.Controllers.ContentPanel
{
    public interface ContentPanelController
    {
        void OpenSettingForm();
        void OpenPriceForm();
        void OpenNewsForm();
        void OpenSeanceForm();
        void OpenAdminForms();
        void OpenUserForm();
        void OpenMoviesForm();
    }
}