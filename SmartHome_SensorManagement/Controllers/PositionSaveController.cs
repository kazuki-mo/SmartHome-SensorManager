using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web;
using System.Web.Mvc;

using SmartHome_SensorManagement.Models;

namespace SmartHome_SensorManagement.Controllers {
    public class PositionSaveController : ApiController {

        SensorConditionEntities db = new SensorConditionEntities();

        // GET api/positionsave
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/positionsave/5
        public string Get(int id) {
            return "value";
        }

        // POST api/positionsave
        public string Post([FromBody]string value) {

            string[] values = value.Split(',');
            int i = 0;
            foreach (var row in db.EnvironmentSensors) {
                row.Position = values[i*2]+","+values[i*2+1];
                //db.SaveChanges();
                i++;
            }

            db.SaveChanges();

            return value;
        }

        // PUT api/positionsave/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/positionsave/5
        public void Delete(int id) {
        }
    }
}
