using System;

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
