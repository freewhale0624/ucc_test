using System;
using System.Web;

namespace Mod13_2
{
    public class CustomHandler : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //write your handler implementation here.

            context.Response.Write(DateTime.Now.ToString());

            //a.jpg
            //1.讀取a.jpg的二進位資料
            //2.利用Response傳回給cliet
            //context.Response.OutputStream
        }

        #endregion
    }
}
