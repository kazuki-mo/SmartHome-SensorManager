using System.Web;
using System.Web.Mvc;

namespace SmartHome_SensorManagement {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}