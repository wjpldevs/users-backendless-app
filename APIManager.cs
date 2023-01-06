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

        private string APPLICATION_ID = "9F235ABC-7A37-20DB-FF84-845623BF7800";
        private string API_KEY = "466979EA-746E-4AA1-AED0-EB564B7C3419";

        public APIManager() {
            Backendless.InitApp(APPLICATION_ID, API_KEY);
        }

    }
}
