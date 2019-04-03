using System.ComponentModel;
using System.Diagnostics;

namespace CSharp8._0._Intro
{
    [Description("[0] Intro")]
    class IntroSlides
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/always-up-to-d8/live#/";

            var psi = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
