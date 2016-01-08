using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SmartHome_SensorManagement.Models;

namespace SmartHome_SensorManagement.Controllers {
    public class HomeController : Controller {

        SensorConditionEntities db = new SensorConditionEntities();

        public ActionResult Index() {
            
            ViewBag.Message = "Main Page";

            return View(db);
        }

        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Environment() {
            ViewBag.Message = "Sensor Config Page";
            
            return View(db.EnvironmentSensors);
        }
        public ActionResult Power() {
            ViewBag.Message = "Sensor Config Page";

            return View(db.PowerSensors);
        }
        public ActionResult Door() {
            ViewBag.Message = "Sensor Config Page";

            return View(db.DoorSensors);
        }
        public ActionResult Position() {
            ViewBag.Message = "Sensor Config Page";

            return View(db.PositionSensors);
        }

        public ActionResult ChangePowerInfo(int sensorID) {

            var target = db.PowerSensors.Where(p => p.SensorID == sensorID).SingleOrDefault();

            return View(target);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePowerInfo(PowerSensor model) {

            if (ModelState.IsValid) {

                var target = db.PowerSensors.Where(p => p.SensorID == model.SensorID).SingleOrDefault();

                target.ConsumerElectronics = model.ConsumerElectronics;
                target.Detail = model.Detail;
                db.SaveChanges();

                return RedirectToAction("Power", "Home");
            }

            // ここで問題が発生した場合はフォームを再表示します
            return View(model);
        }

        public ActionResult ChangeEnvironmentInfo(int sensorID) {

            var target = db.EnvironmentSensors.Where(p => p.SensorID == sensorID).SingleOrDefault();

            return View(target);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeEnvironmentInfo(EnvironmentSensor model) {

            if (ModelState.IsValid) {

                var target = db.EnvironmentSensors.Where(p => p.SensorID == model.SensorID).SingleOrDefault();

                target.BatteryExchangeDate = model.BatteryExchangeDate;
                target.Detail = model.Detail;
                db.SaveChanges();

                return RedirectToAction("Environment", "Home");
            }

            // ここで問題が発生した場合はフォームを再表示します
            return View(model);
        }

        public ActionResult ChangeDoorInfo(int sensorID) {

            var target = db.DoorSensors.Where(p => p.SensorID == sensorID).SingleOrDefault();

            return View(target);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeDoorInfo(DoorSensor model) {

            if (ModelState.IsValid) {

                var target = db.DoorSensors.Where(p => p.SensorID == model.SensorID).SingleOrDefault();

                target.Door = model.Door;
                target.BatteryExchangeDate = model.BatteryExchangeDate;
                target.Detail = model.Detail;
                db.SaveChanges();

                return RedirectToAction("Door", "Home");
            }

            // ここで問題が発生した場合はフォームを再表示します
            return View(model);
        }

        public ActionResult ChangePositionInfo(int sensorID) {

            var target = db.PositionSensors.Where(p => p.SensorID == sensorID).SingleOrDefault();

            return View(target);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePositionInfo(DoorSensor model) {

            if (ModelState.IsValid) {

                var target = db.PositionSensors.Where(p => p.SensorID == model.SensorID).SingleOrDefault();

                target.Detail = model.Detail;
                db.SaveChanges();

                return RedirectToAction("Position", "Home");
            }

            // ここで問題が発生した場合はフォームを再表示します
            return View(model);
        }
    }
}
