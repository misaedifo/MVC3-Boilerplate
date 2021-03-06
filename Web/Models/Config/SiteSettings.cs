﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Net.Mail;

namespace Web.Models.Config
{
    public static class SiteSettings
    {
        public static string ApplicationName
        {
            get
            {
                return ConfigurationManager.AppSettings["ApplicationName"];
            }
        }

        /// <summary>
        /// Returns the virtual path to the Email Templates directory with a trailing "/".
        /// </summary>
        /// <returns></returns>
        public static string EmailTemplatesVirtualPath
        {
            get
            {
                return ConfigurationManager.AppSettings["EmailTemplatesVirtualPath"];
            }
        }

        public static SmtpClient GetSmtpClient()
        {
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            return client;
        }
    }
}