using System.ComponentModel;
using System.Diagnostics;

namespace CSharp8Demo.Intro
{
    [Description("[0] Intro")]
    class IntroSlides
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/always-up-to-d8/live#/";

            var psi = new ProcessStartInfo("chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
