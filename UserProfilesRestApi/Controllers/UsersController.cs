using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using UserProfilesRestApi.Models;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace UserProfilesRestApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        // GET: api/Users
        public IEnumerable<object> Get()
        {
            return new string[] { "value1", "value2" };

        }

        // GET: api/Users/5
        public string Get(string id)
        {
            //return "value";

            List<string> strs = new List<string>();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnectionString"].ToString();
            
            using (SqlConnection con = new SqlConnection(conString))

            {
                string sql = string.Empty;
                if(id.IndexOf(".com")>-1)
                {
                    sql = string.Format("SELECT * FROM EKAM_Extract WHERE EMAIL_ADDR = '{0}'", id);
                }
                else
                    sql = string.Format("SELECT * FROM EKAM_Extract WHERE EMPLID = '{0}'", id);

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))

                {
                    DataSet ds = new DataSet();

                    adapter.Fill(ds);

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

                    {
                        for(int j=0; j< ds.Tables[0].Columns.Count;j++)
                        {
                            string str = (string)ds.Tables[0].Rows[i][j];
                            strs.Add(str);
                        }

                    }

                }
            }

            User user = new User(strs[0], strs[1],strs[2], strs[3], strs[4], strs[5], strs[6], strs[7], strs[8], strs[9],
                strs[10], strs[11], strs[12], strs[13], strs[14], strs[15], strs[16], strs[17], strs[18], strs[19],
                strs[20], strs[21], strs[22], strs[23], strs[24], strs[25], strs[26], strs[27], strs[28], strs[29],
                strs[30], strs[31], strs[32], strs[33], strs[34], strs[35], strs[36], strs[37], strs[38], strs[39],
                strs[40], strs[41], strs[42], strs[43], strs[44], strs[45], strs[46], strs[47], strs[48], strs[49],
                strs[50], strs[51], strs[52], strs[53], strs[54], strs[55], strs[56], strs[57], strs[58], strs[59], strs[60]);

            return JsonConvert.SerializeObject(user); 

        }
    

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
