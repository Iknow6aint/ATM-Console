// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
public class ATMAPP : IUserLogin
{
    private List<UserAccount> userAccountList;
    private UserAccount selectedAccount;


    public void InitializeData()
    {
        userAccountList = new List<UserAccount>{
            new UserAccount{Id =1, FullName = " saintmoses agbukor", AccountNumber=123456, CardNumber= 232323, CardPin=123123,AccountBalance=5000.00m, IsLocked=false},
            new UserAccount{Id =2, FullName = " Amaka hope", AccountNumber=123345, CardNumber= 233245, CardPin=124545,AccountBalance=4000.00m, IsLocked=false},
            new UserAccount{Id =3, FullName = " Rich kids", AccountNumber=123321, CardNumber= 233565, CardPin=123653,AccountBalance=3000.00m, IsLocked=true}
        };
    }
    public void CheckUserCardNumberAndPassword()
    {
        bool isCorrectLogin = false;
        UserAccount inputAcount = AppScreen.UserLoginForm();

    }


}
