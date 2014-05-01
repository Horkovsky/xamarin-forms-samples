﻿using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Xamarin;
using Meetum.Views;
using System.Threading.Tasks;

namespace Meetum.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            window = new UIWindow (UIScreen.MainScreen.Bounds);
            
            Meetum.Init(typeof(Meetum).Assembly);
            Forms.Init();
            FormsMaps.Init();

            window.RootViewController = BuildView();
            window.MakeKeyAndVisible ();
            
            return true;
        }

        static UIViewController BuildView()
        {
            var root = new RootPage();
            var controller = root.CreateViewController();
//            root.LoadData();
            return controller;
        }
    }
}
