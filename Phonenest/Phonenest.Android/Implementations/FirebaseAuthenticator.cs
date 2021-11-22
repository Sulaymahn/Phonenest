using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Auth;
using Phonenest.CustomInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(Phonenest.Droid.Implementations.FirebaseAuthenticator))]
namespace Phonenest.Droid.Implementations
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator
    {
        public async Task<bool> AddUser(string email, string password)
        {
            try
            {
                await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsSignIn()
        {
            var user = FirebaseAuth.Instance.CurrentUser;
            return user != null;
        }

        public async Task<string> LoginWithEmailAndPass(string email, string password)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = user.User.GetIdToken(false);
                return token.ToString();
            }
            catch (FirebaseAuthException)
            {
                return String.Empty;
            }
        }

        public async Task<bool> LogInWithToken(string token)
        {
            var user = await FirebaseAuth.Instance.SignInWithCustomTokenAsync(token);
            if(user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool SignOut()
        {
            try
            {
                FirebaseAuth.Instance.SignOut();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}