using System;
using System.Web;

namespace Mod13_1
{
    public class CustomModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += (s, e) => {
                string url = context.Context.Request.QueryString["url"];
                if (url != null)
                {
                    context.Context.Response.Redirect(url);
                }
            };

        }

        #endregion


    }
}
