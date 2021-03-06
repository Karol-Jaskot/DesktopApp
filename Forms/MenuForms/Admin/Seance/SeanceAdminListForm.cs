﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Controllers.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.AdminServices.MoviesServices;
using DesktopApp.Backend.Services.AdminServices.SeanceServices;
using DesktopApp.Backend.Services.DesingerServices;
using DesktopApp.Forms.MenuForms.Admin.Movies;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Seance
{
    public partial class SeanceAdminListForm : MaterialForm
    {
        private DesingerService desingerService;
        private SeanceAdminService seanceService;
        private ListFormService listFormService;
        private List<Backend.Data.Seance> seances;
        public SeanceAdminListForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            seanceService = SeanceAdminServiceImpl.GetService();
            listFormService = new ListFormService();

            DownloadList();
            listFormService.SetControlButtonsAndLabel(previusPageButton, nextPageButton, pageNumberLabel);
            listFormService.SetInfoPanel(infoLabel);

            ConnectPanels();
            ConnectForms();

            listFormService.ShowForms();
        }

        private void ConnectForms()
        {
            List<MaterialForm> forms = new List<MaterialForm>();
            foreach (Backend.Data.Seance seance in seances)
            {
                forms.Add(new SeanceAdminInfoForm(seance));
            }
            listFormService.SetForms(forms);
        }

        private void ConnectPanels()
        {
            List<Panel> panels = new List<Panel>();
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);
            panels.Add(panel5);
            panels.Add(panel6);
            listFormService.SetPanels(panels);
        }

        private void DownloadList()
        {
            seances = seanceService.GetSeanceList();
        }

        private void previusPageButton_Click(object sender, EventArgs e)
        {
            listFormService.PreviusePage();
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            listFormService.NextPage();
        }
    }
}
