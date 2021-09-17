using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NetCore3._1SwaggerKullanimi.Model;

namespace NetCore3._1SwaggerKullanimi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public List<Orders> GetAllOrders()
        {
            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-E9UTSVL;Initial Catalog=KahveSiparis;Integrated Security=True");
            bgl.Open();
            SqlCommand komut = new SqlCommand("select [SipId],[SipAdSoyad],[SipTelNo],[SipAdres],[SipTutar] from [orders]", bgl);
            DataTable tablo = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tablo);

            List<Orders> order = new List<Orders>();

            order = tablo.AsEnumerable().Select(s => new Orders
            {
                SipId = s.Field<int>("SipId"),
                SipAdSoyad = s.Field<string>("SipAdSoyad"),
                SipTelNo = s.Field<string>("SipTelNo"),
                SipAdres = s.Field<string>("SipAdres"),
                SipTutar = s.Field<decimal>("SipTutar")
            }).ToList();

            return order;
        }
    }

}