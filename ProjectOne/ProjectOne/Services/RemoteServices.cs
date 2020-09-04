using Firebase.Database;
using Firebase.Database.Query;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace ProjectOne.Services
{
     public class RemoteServices
    {
        public FirebaseClient firebase = new FirebaseClient("https://mia-s-kitchen.firebaseio.com/");

        public async Task<bool> SignUpAsync(SignUp signUp)
        {
            try
            {
                await firebase
                    .Child("Users")
                    .PostAsync(new SignUp()
                    {
                        Surname = signUp.Surname,
                        FirstName = signUp.FirstName,
                        Email = signUp.Email,
                        Address = signUp.Address,
                        MobileNumber = signUp.MobileNumber,
                        Password = signUp.Password,
                        ConfrimPassword = signUp.ConfrimPassword,
                        Avatar = "https://xamarin.com/content/images/pages/forms/example-app.png"
                    });
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error: {e}");
                return false;
            }

        }

        public async Task<List<SignUp>> GetAllAccounts()
        {
            try
            {
                var signUpList = (await firebase
                    .Child("Users")
                    .OnceAsync<SignUp>()).Select(item => 
                    new SignUp
                    {
                        Surname = item.Object.Surname,
                        FirstName = item.Object.FirstName,
                        Email = item.Object.Email,
                        Address = item.Object.Address,
                        MobileNumber = item.Object.MobileNumber,
                        Password = item.Object.Password,
                        ConfrimPassword = item.Object.ConfrimPassword,
                        Avatar = item.Object.Avatar

                    }).ToList();


                return signUpList;
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
        }
        public async Task<SignUp> LoginAsync(Login login)
        {
            try
            {
                var onUser = await GetAllAccounts();
                await firebase
                    .Child("Users")
                    .OnceAsync<SignUp>();
                return onUser.Where(a=> a.Email == login.Email && a.Password == login.Password).FirstOrDefault();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error:{e}");
                return null;
            }
            
        }


     }
}
