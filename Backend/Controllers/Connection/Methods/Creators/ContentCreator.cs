﻿using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class ContentCreator
    {

        public static FormUrlEncodedContent CreateContent(AuthData user)
        {
            return new FormUrlEncodedContent(CreatePairs(user));
        }

        public static FormUrlEncodedContent CreateContent(Article article)
        {
            return new FormUrlEncodedContent(CreatePairs(article));
        }

        private static List<KeyValuePair<string, string>> CreatePairs(AuthData user)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("email", user.GetEmail()),
                new KeyValuePair<string, string>("password", user.GetPassword())
            };
            return pairs;
        }

        private static List<KeyValuePair<string, string>> CreatePairs(Article article)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("title", article.GetTitle()),
                new KeyValuePair<string, string>("description", article.GetDescription())
            };
            return pairs;
        }
    }
}