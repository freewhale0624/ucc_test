using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Mod09.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(System.Web.Optimization.BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
              "~/Scripts/jquery-{version}.js",
              "~/Scripts/jquery-ui-{version}.js"));
        }
    }


}