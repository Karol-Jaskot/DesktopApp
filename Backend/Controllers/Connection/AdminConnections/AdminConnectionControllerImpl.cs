﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.JsonPatch;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Backend.Configuration;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Controllers.Connection.Methods.DialogInfo;
using DesktopApp.Backend.Data;
using DesktopApp.Backend.Services.UserServices;

namespace DesktopApp.Backend.Controllers.Connection.AdminConnections
{
    public class AdminConnectionControllerImpl : AdminConnectionController
    {
        private HttpClient client;
        private string serverAdress = BasicConfiguration.GetServerAdress();
        private UserService userService;

        public static AdminConnectionController GetController()
        {
            return new AdminConnectionControllerImpl();
        }

        private AdminConnectionControllerImpl()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(serverAdress)
            };
            userService = UserServiceImpl.GetInstance();
        }

        public void SendArticle(Article article)
        {
            var content = ContentCreator.CreateContent(article);
            SetAuthorization();
            HttpResponseMessage response = client.PostAsync("/api/admin/articles", content).Result;
            if (response.StatusCode != HttpStatusCode.Created)
            {
                DialogMessage.ShowInfo("Błąd wysyłania!");
            }
        }

        public List<Article> GetAdminArticlesFromServer()
        {
            List<Article> articles;
            SetAuthorization();
            HttpResponseMessage response = client.GetAsync("/api/admin/articles").Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                articles = ArticleListCreator.CreateArticles(response);
                return articles;
            }

            DialogMessage.ShowInfo("Błąd pobierania artykułów!");
            return null;
        }

        public void ChangeArticleStatus(Article article)
        {
            SetAuthorization();
            string patchUrl = "/api/admin/articles/" + article.GetId() + "/status";
            var content = ContentCreator.CreateContent(article.GetStatus());
            HttpResponseMessage response = client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), patchUrl)
            {
                Content = content
            }).Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                DialogMessage.ShowInfo("Błąd zmiany statusu!");
            }
        }

        public void DeleteArticle(Article article)
        {
            SetAuthorization();
            string patchUrl = "/api/admin/articles/" + article.GetId();
            HttpResponseMessage response = client.DeleteAsync(patchUrl).Result;
            if (response.StatusCode != HttpStatusCode.NoContent)
            {
                DialogMessage.ShowInfo("Błąd usuwania artykułu!");
            }
        }

        private void SetAuthorization()
        {
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", userService.GetUserToken());
        }

    }
}