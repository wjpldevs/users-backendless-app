using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendlessAPI;

namespace users_backendless_app
{
    public sealed class APIManager
    {
        private static APIManager? shared;

        public static APIManager GetInstance() {
            if (shared == null) 
            {
                shared = new APIManager();
            }
            return shared;
        }

        private string APPLICATION_ID = "5C46944E-7CA7-6C53-FF80-756D51F52D00";
        private string API_KEY = "791995C2-5825-4EA2-9C1F-941561BBAD01";

        public APIManager() {
            Backendless.InitApp(APPLICATION_ID, API_KEY);
        }

    }
}
