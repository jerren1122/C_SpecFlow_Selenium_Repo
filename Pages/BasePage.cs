using System;
using System.Collections.Generic;
using System.Text;
using CSpecFlowSelenium.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSpecFlowSelenium.Pages
{
   public class BasePage
    {

        public virtual void Fill(String text)
        {
            Console.WriteLine("override at the class level " + text);
        }

        public virtual void Select(String text)
        {
            Console.WriteLine("override at the class level " + text);
        }

    }
}
