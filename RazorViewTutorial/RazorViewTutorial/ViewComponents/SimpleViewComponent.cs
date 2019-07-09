using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorViewTutorial.ViewComponents
{
    public class SimpleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string additionalData)
        {
            var data = GetSampleData(additionalData);
            return View(data);
        }



        private List<string> GetSampleData(string additionalData)
        {
            List<string> data = new List<string>();
            data.Add("One");
            data.Add("Two");
            data.Add("Three");
            data.Add(additionalData);
            return data;
        }
    }
}