using System;
using System.Collections.Generic;

namespace BankApp
{
    public class mainProgram
    {
        public static void Main(string[] args)
        {
            var ussd = "*966#";
            String? response;

            // dailing the ussd code
            Console.WriteLine("Login pin is: *966#");
            Console.WriteLine("enter pin>: ");
            response = Console.ReadLine();
            

            // checking pin!
            if (response == ussd)
            {
                displayMessage();
            }
            else
            {
                Console.WriteLine("Incorrect ussd pin");
            }

            selection();
    
        }

        // prompt message
        public static void displayMessage(){
            Console.WriteLine("*****************************************");
            Console.WriteLine("Hello, and welcome to SpaceX EazyBanking.\nEnter a number to pick a service.");
            Console.WriteLine("1. Create account\n2. Check balance\n3. Transfar\n4. Buy airtime\n5. Buy data\n>:");
        }
        
        // selection section
        public static void selection(){
            int reply;
            int _pin;

            try
            { 
                reply = Convert.ToInt32(Console.ReadLine());
                var accountNumber = 2345345678; 

                switch (reply)
                {
                    case 1:
                        String? _firstName;
                        String? _lastName;
                        String? _dob;
                        String? _age;
                        Console.WriteLine("Creating account......");
                        Console.WriteLine("Pls enter your first name: ");
                        _firstName = Console.ReadLine();
                        Console.WriteLine("Pls enter your last name: ");
                        _lastName = Console.ReadLine();
                        Console.WriteLine("Pls enter your date of birth(dd/mm/yyyy): ");
                        _dob = Console.ReadLine();
                        Console.WriteLine("Pls enter your age: ");
                        _age = Console.ReadLine();
                        createAccount myAccount = new createAccount(_firstName, _lastName, _dob, _age);

                        Console.WriteLine("Processing......");
                        List<string?> accountDetails = new List<string?>();
                        accountDetails.Add(_firstName);
                        accountDetails.Add(_lastName);
                        accountDetails.Add(_dob);
                        accountDetails.Add(_age);
                        Console.WriteLine("*******************************************");
                        Console.WriteLine("Thanks for providing the necessary details.\nAccount created successfully! ");
                        Console.WriteLine($"Your account number is: {accountNumber}\nYour account name is: {_firstName} {_lastName}");
                        Console.WriteLine("*******************************************");
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Enter pin: ");
                            _pin = Convert.ToInt32(Console.ReadLine());
                            if (_pin == 1942)
                            {
                                accountBalance checkBalance = new accountBalance(_pin);
                                checkBalance.Balance();
                            } 
                            else{
                                Console.WriteLine("Incorrect pin");
                            } 
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;

                    case 3:
                        int _ammount;
                        ulong _receiverAccountNum;

                            Console.WriteLine("Processing.......");
                        while (true)
                        {
                        try
                        {
                            Console.WriteLine("Enter recipiant account number: ");
                            _receiverAccountNum = Convert.ToUInt64(Console.ReadLine());

                            if (_receiverAccountNum.ToString().Length == 10)
                            {
                                Console.WriteLine("Account number accepted!");
                                break;
                            }
                            else if(_receiverAccountNum.ToString().Length > 10){
                                Console.WriteLine("Account number too long.");
                            }
                            else
                            {
                               Console.WriteLine("Account number too short"); 
                            }
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Inavalid input");
                        }
                        }

                            Console.WriteLine("Enter transfar ammount: ");
                            
                        while (true)
                        { 
                        try
                        {
                            _ammount = Convert.ToInt32(Console.ReadLine());
                            if (_ammount.ToString().Length > 0)
                            {
                                Console.WriteLine("Amount accepted!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Pls enter a valid amount to transfar.");
                            }   
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Invalid input!");
                        }   
                        }
                        transfars bankTransfars = new transfars(_ammount, _receiverAccountNum);
                        bankTransfars.transfar();
                        
                        break;
                    case 4:
                        Console.WriteLine("four was selected");
                        break;

                    case 5:
                        Console.WriteLine("five was selected");
                        break;
                } 
            }
            catch (System.FormatException)
            {
                 Console.WriteLine("Invalid input entered, try again.");
            }
        }   
    }
}