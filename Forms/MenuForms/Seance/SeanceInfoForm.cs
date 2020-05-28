﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.DataServices.HallsServices;
using DesktopApp.Backend.Services.DataServices.MoviesServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Seance
{
    public partial class SeanceInfoForm : MaterialForm
    {
        private DesingerService desingerService;
        private Backend.Data.Seance seance;

        public SeanceInfoForm(Backend.Data.Seance seance)
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);
            desingerService.AddPanelToChangeColor(contentPanel);

            this.seance = seance;
            SetLabels();
        }

        private void SetLabels()
        {
            movieLabel.Text ="Film: "+ MoviesServiceImpl.GetService().GetMoviesList()[seance.GetMovieId()].GetTitle();

            hallLabel.Text ="Sala: "+ HallsServiceImpl.GetService().GetHallsList()[seance.GetHallId()].GetName();

            dateLabel.Text = seance.GetDate();
        }
    }
}