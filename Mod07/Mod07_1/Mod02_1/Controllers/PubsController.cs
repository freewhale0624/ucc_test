using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using Mod02_1.Models;

namespace Mod02_1.Controllers
{
    public class PubsController : Controller
    {
        // GET: Pubs
        public ActionResult Index()
        {
            string cnStr =
            WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            SqlDataAdapter da = new SqlDataAdapter(
                "select * from stores", cnStr);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return View(dt);
        }

        public ActionResult Details(string id)
        {
            string cnStr =
         WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            SqlDataAdapter da = new
               SqlDataAdapter("select * from stores where stor_id=@stor_id",
               cnStr);
            da.SelectCommand.Parameters.AddWithValue("@stor_id", id);

            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            var store = new Store
            {
                stor_id = dt.Rows[0][0].ToString(),
                stor_name = dt.Rows[0][1].ToString()
            };
            return View(store);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                string cnStr =
       WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlConnection cn = new SqlConnection(cnStr);

                SqlCommand cmd = new SqlCommand(
                    "insert into stores(stor_id,stor_name) values(@stor_id ,@stor_name)", cn);

                cmd.Parameters.AddWithValue("@stor_id", collection["stor_id"]);
                cmd.Parameters.AddWithValue("@stor_name", collection["stor_name"]);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(string id)
        {
            string cnStr =
      WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            SqlDataAdapter da = new
               SqlDataAdapter("select * from stores where stor_id=@stor_id",
               cnStr);
            da.SelectCommand.Parameters.AddWithValue("@stor_id", id);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            var store = new Store
            {
                stor_id = dt.Rows[0][0].ToString(),
                stor_name = dt.Rows[0][1].ToString()
            };
            return View(store);
        }

        [HttpPost]
        public ActionResult Edit(Store s)
        {
            try
            {
                string cnStr =
WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlConnection cn = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand(
                    "UPDATE stores SET stor_name = @stor_name WHERE [stor_id] = @stor_id", cn);
                cmd.Parameters.AddWithValue("@stor_id", s.stor_id);
                cmd.Parameters.AddWithValue("@stor_name", s.stor_name);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(string id)
        {
            string cnStr =
WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            SqlDataAdapter da = new
                 SqlDataAdapter("select * from stores where stor_id=@stor_id", cnStr);
            da.SelectCommand.Parameters.AddWithValue("@stor_id", id);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);

            Store s = new Store
            {
                stor_id = dt.Rows[0][0].ToString(),
                stor_name = dt.Rows[0][1].ToString()

            };
            return View(s);
        }


        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                string cnStr =
WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlConnection cn = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand(
                    "delete [stores] where [stor_id] = @stor_id", cn);
                cmd.Parameters.AddWithValue("@stor_id", id);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}