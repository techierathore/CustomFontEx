using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace CustomFontEx.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            // Lets log them to our output window.
            //LogFonts();
            return base.FinishedLaunching(app, options);
        }
        /// <summary>
        /// Logs the installed fonts to the debug window.
        /// </summary>
        private void LogFonts()
        {
            var iCount = 0;
            foreach (NSString family in UIFont.FamilyNames)
            {
                foreach (NSString font in UIFont.FontNamesForFamilyName(family))
                {
                    Console.WriteLine(@"Font No: {0} , Name : {1} , Description: {2}",iCount, font, font.Description);
                    iCount++;
                }
            }
        }

    }
}
