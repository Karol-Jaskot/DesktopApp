﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.AdminServices.HallsServices;
using DesktopApp.Backend.Services.AdminServices.MoviesServices;
using DesktopApp.Backend.Services.AdminServices.SeanceServices;
using DesktopApp.Backend.Services.DesingerServices;
using MaterialSkin.Controls;

namespace DesktopApp.Forms.MenuForms.Admin.Seance
{
    public partial class AddSeanceForm : MaterialForm
    {
        private DesingerService desingerService;
        private List<Movie> movies;
        private int checkMovie =0;

        private List<Hall> halls;
        private int checkHall = 0;

        public AddSeanceForm()
        {
            InitializeComponent();
            desingerService = DesingerServiceImpl.GetInstance();
            desingerService.AddFormToDesinger(this);

            MoviesAdminService moviesService = MoviesAdminServiceImpl.GetService();
            movies = moviesService.GetMoviesListForAdmin();
            movieLabel.Text = movies[checkMovie].GetTitle();

            HallsAdminService hallsService = HallsAdminServiceImpl.GetService();
            halls = hallsService.GetHallsListForAdmin();
            hallLabel.Text = halls[checkHall].GetName();

            timePickerData.Format = DateTimePickerFormat.Custom;
            timePickerData.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        private void nextMovieButtopn_Click(object sender, EventArgs e)
        {
            if (checkMovie < (movies.Count - 1))
                checkMovie++;
            else
                checkMovie = 0;

            movieLabel.Text = movies[checkMovie].GetTitle();
            
        }

        private void previoseMovieButton_Click(object sender, EventArgs e)
        {
            if (checkMovie > 0)
                checkMovie--;
            else
                checkMovie = movies.Count - 1;

            movieLabel.Text = movies[checkMovie].GetTitle();
        }

        private void nextHallButton_Click(object sender, EventArgs e)
        {
            if (checkHall < (halls.Count - 1))
                checkHall++;
            else
                checkHall = 0;

            hallLabel.Text = halls[checkHall].GetName();
        }

        private void previoseHallButton_Click(object sender, EventArgs e)
        {
            if (checkHall > 0)
                checkHall--;
            else
                checkHall = halls.Count - 1;

            hallLabel.Text = halls[checkHall].GetName();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Backend.Data.Seance  seance = new Backend.Data.Seance();

            seance.SetMovieId(movies[checkMovie].GetId());
            seance.SetHallId(halls[checkHall].GetId());

            seance.SetDate(timePickerData.Value.ToString("yyyy-MM-ddThh:mm:ss.311Z"));

            SeanceAdminServiceImpl.GetService().SendSeanceToServer(seance);
        }
    }
}
