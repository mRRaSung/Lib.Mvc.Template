using System;
using System.ComponentModel.DataAnnotations;

namespace Lib.Mvc.Template.ViewModels.Home
{
    public class AboutViewModel
    {
        public string Title { get; set; }

        //[UIHint("CDate")]
        public DateTime DT { get; set; }
    }
}