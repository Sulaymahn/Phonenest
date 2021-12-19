using Phonenest.CustomInterfaces;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using Environment = System.Environment;

[assembly: Dependency(typeof(Phonenest.Droid.Implementations.LocalStorage))]
namespace Phonenest.Droid.Implementations
{
    public class LocalStorage : ILocalStorage
    {
        string _tokenAddress = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "token.txt";
        

        public string[] GetCredential()
        {
            if (!File.Exists(_tokenAddress)) return null;
            return File.ReadAllLines(_tokenAddress);
        }

        public async void SaveCredential(string email, string password)
        {
            using var writer = File.CreateText(_tokenAddress);
            await writer.WriteLineAsync(email);
            await writer.WriteLineAsync(password);
        }

        public void DeleteCredential()
        {
            if(File.Exists(_tokenAddress)) File.Delete(_tokenAddress);
        }
    }
}