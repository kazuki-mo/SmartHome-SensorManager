using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartHome_SensorManagement.Models;

namespace SmartHome_SensorManagement.Controllers {
    public class DoorInfoController : ApiController {
        // GET api/doorinfo
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/doorinfo/5
        public List<DoorInfo> Get(string id) {

            List<DoorInfo> doorinfos = new List<DoorInfo>();

            SensorConditionEntities db = new SensorConditionEntities();
            foreach (var row in db.DoorSensors) {
                DoorInfo doorinfo = new DoorInfo();
                doorinfo.SensorID = row.SensorID.ToString();
                if (id.Equals("Door")) {
                    doorinfo.Door = row.Door;
                } else if (id.Equals("BatteryExchangeDate")) {
                    doorinfo.BatteryExchangeDate = row.BatteryExchangeDate;
                } else if (id.Equals("LatestUploadDate")) {
                    doorinfo.LatestUploadDate = row.LatestUploadDate;
                } else if (id.Equals("BaseStationName")) {
                    doorinfo.BaseStationName = row.BaseStationName;
                } else if (id.Equals("Detail")) {
                    doorinfo.Detail = row.Detail;
                } else if (id.Equals("All")) {
                    doorinfo.Door = row.Door;
                    doorinfo.BatteryExchangeDate = row.BatteryExchangeDate;
                    doorinfo.LatestUploadDate = row.LatestUploadDate;
                    doorinfo.BaseStationName = row.BaseStationName;
                    doorinfo.Detail = row.Detail;
                }
                doorinfos.Add(doorinfo);
            }


            return doorinfos;
        }

        // POST api/doorinfo
        public void Post([FromBody]string value) {
        }

        // PUT api/doorinfo/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/doorinfo/5
        public void Delete(int id) {
        }
    }
}
