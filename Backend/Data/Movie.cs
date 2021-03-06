﻿using System.Collections.Generic;

namespace DesktopApp.Backend.Data
{
    public class Movie
    {
        private int id;
        private string title;
        private string description;
        private string director;
        private List<Comment> comments;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDirector(string director)
        {
            this.director = director;
        }

        public string GetDirector()
        {
            return director;
        }

        public List<Comment> GetCommentsList()
        {
            return comments;
        }

        public void SetCommentsList(List<Comment> comments)
        {
            this.comments = comments;
        }
    }
}