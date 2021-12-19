using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phonenest.Droid.Helpers
{
    public static class AppData
    {
        private static FirebaseApp app = FirebaseApp.InitializeApp(Application.Context);

        private static FirebaseApp FirebaseApp
        {
            get
            {
                if (app == null)
                {
                    var option = new Firebase.FirebaseOptions.Builder()
                        .SetApplicationId("phonest-ed100")
                        .SetApiKey("AIzaSyAieDh2XqGdf6rtPJywesmpoe86Hu2hBYY")
                        .SetDatabaseUrl("https://phonest-ed100-default-rtdb.firebaseio.com/")
                        .SetStorageBucket("phonest-ed100.appspot.com")
                        .Build();

                    app = FirebaseApp.InitializeApp(Application.Context, option);
                }

                return app;
            }
        }

        public static FirebaseDatabase GetDatabase()
        {
            return FirebaseDatabase.GetInstance(FirebaseApp);
        }

        public static FirebaseAuth GetAuth()
        {
            return FirebaseAuth.GetInstance(FirebaseApp);
        }
    }
}