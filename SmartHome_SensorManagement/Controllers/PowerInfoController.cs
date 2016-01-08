using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartHome_SensorManagement.Models;

namespace SmartHome_SensorManagement.Controllers {
    public class PowerInfoController : ApiController {
        // GET api/powerinfo
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET api/powerinfo/5
        public List<PowerInfo> Get(string id) {

            List<PowerInfo> powerinfos = new List<PowerInfo>();

            SensorConditionEntities db = new SensorConditionEntities();
            foreach (var row in db.PowerSensors) {
                PowerInfo powerinfo = new PowerInfo();
                powerinfo.SensorID = row.SensorID.ToString();
                if (id.Equals("ConsumerElectronics")) {
                    powerinfo.ConsumerElectronics = row.ConsumerElectronics;
                } else if (id.Equals("Type")) {
                    powerinfo.Type = row.Type;
                } else if (id.Equals("LatestUploadDate")) {
                    powerinfo.LatestUploadDate = row.LatestUploadDate;
                } else if (id.Equals("BaseStationName")) {
                    powerinfo.BaseStationName = row.BaseStationName;
                } else if (id.Equals("UploadCycle")) {
                    powerinfo.UploadCycle = row.UploadCycle;
                } else if (id.Equals("Detail")) {
                    powerinfo.Detail = row.Detail;
                } else if (id.Equals("All")) {
                    powerinfo.ConsumerElectronics = row.ConsumerElectronics;
                    powerinfo.Type = row.Type;
                    powerinfo.LatestUploadDate = row.LatestUploadDate;
                    powerinfo.BaseStationName = row.BaseStationName;
                    powerinfo.UploadCycle = row.UploadCycle;
                    powerinfo.Detail = row.Detail;
                }
                powerinfos.Add(powerinfo);
            }


            return powerinfos;
        }

        // POST api/powerinfo
        public void Post([FromBody]string value) {
        }

        // PUT api/powerinfo/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/powerinfo/5
        public void Delete(int id) {
        }
    }
}
