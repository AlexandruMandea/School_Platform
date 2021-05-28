using SchoolPlatform.Models.Entities;
using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace SchoolPlatform.Services
{
    class Helper
    {
        public static User CurrentUser { get; set; }
        public static int CurrentUserID { get; set; }
        public static string CurrentUsername { get; set; }
        public static string CurrentPassword { get; set; }
    }
}
