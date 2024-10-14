using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _3_Cases
{
    public class Password
    {
        //   public bool islogin_or_created_account = false;
        // public bool islogin_or_created_account = false;

        public static bool islogin_or_created_account { get; set; }

        


        public static  void Password_System()
        {

           
            

            string Password; // old pasword
            string newPassword;                                // lav noget kode som ogå tjekker om brugernavn findes.... og password korrket

            string brugernavn;
            string menuSTART;

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Passoword.txt");
            /// @"C:\Users\Gusher\Desktop\PasswordTekstfil\Passwords.txt"; it does the same as below down here 

      


            bool restartmenu = true;
            bool passwordcorrect = true;


            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }

            if (File.Exists(path))
            {
                Console.Write("1: Create Account, 2 Login in to your account, 3 Ændre dit password: ");
                menuSTART = Console.ReadLine();

                if (menuSTART == "3")
                {
                    Console.WriteLine("Du skal lige først loggin, så vi ved hvilken brugers password der skal ændres");
                    Console.Write("Brugernavn: ");
                    brugernavn = Console.ReadLine().ToLower();

                    Console.Write("Password: ");
                    Password = Console.ReadLine().ToLower();

                    if (CheckCredentialse_kunpassword(brugernavn, Password))
                    {
                        Console.WriteLine("Sandforsætelse");
                    }
                    else
                    {
                        Console.WriteLine("Falsk");
                    }






                    while (restartmenu == true)
                    {
                        if (CheckPasswordInFile_CheckBrugernavn_i_fil(Password, brugernavn, path))
                        {
                            Console.WriteLine("Logget ind....");
                            restartmenu = false;

                          //  islogin_or_created_acco = true;

                            Console.Write("Nyt Password: ");
                            newPassword = Console.ReadLine().ToLower();

                            if (CheckCredentials(brugernavn, newPassword, Password))
                            {
                                Console.WriteLine("forsættelse");
                            }
                            else
                            {
                                Console.WriteLine("Falsk");
                            }


                            if (ChangePasswordInFile(Password, newPassword, path))
                            {
                                Console.WriteLine("Password skrift fullført.");
                                islogin_or_created_account = true;
                            }
                            else
                            {

                                Console.WriteLine("Password skrift fejlede");
                            }


                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Brugernavn eller password er forkert angivet.");
                            Console.Write("Brugernavn: ");

                            brugernavn = Console.ReadLine().ToLower();
                            Console.Write("Password: ");
                            Password = Console.ReadLine().ToLower();
                            restartmenu = true;

                        }
                    }



                }


                
                if (menuSTART == "2")
                {
                    Console.WriteLine("");
                    Console.Write("Brugernavn: ");
                    brugernavn = Console.ReadLine();

                    Console.Write("Password: ");
                    Password = Console.ReadLine().ToLower();
                    while (restartmenu == true)
                    {
                        if (CheckPasswordInFile_CheckBrugernavn_i_fil(Password,brugernavn, path))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Logget ind.");
                            restartmenu = false;
                            Console.WriteLine("");
                            Console.Write("Nyt Password: ");
                            newPassword = Console.ReadLine();

                            if (ChangePasswordInFile(Password, newPassword, path))
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Password skrift fullført.");
                                restartmenu=false;
                                islogin_or_created_account = true;
                            }
                            else
                            {
                                Console.WriteLine("Password skrift fejlede");
                            }





                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Forkert Password eller Brugernavn.");
                            Console.WriteLine("");
                            Console.Write("Brugernavn: ");
                            brugernavn = Console.ReadLine().ToLower();
                            Console.Write("Password: ");
                            Password = Console.ReadLine().ToLower();
                            restartmenu = true;
                  
                        }
                    }

                }
                
                if (menuSTART == "1")
                {
                    Console.WriteLine("");
                    Console.Write("Brugernavn: "); // MAKE code that check if that user name all exists
                    brugernavn = Console.ReadLine().ToLower();


                    Console.Write("password minium 12: ");
                    Password = Console.ReadLine().ToLower();




                    while (passwordcorrect == true) // Lad noget kode som tjekker om passwordet allerede existere, man må ikke kunne skrive tal i slutning af starten af passworet 
                    {

                        if (Password.Length <= 11 || Password.Contains(" ") || char.IsDigit(Password[0]) || char.IsDigit(Password[Password.Length - 1]))
                        {
                            Console.WriteLine("");
                            Console.Write("IKKE GODKENDT password: ");
                            passwordcorrect = true;
                            Password = Console.ReadLine().ToLower();


                        }
                        else
                        {

                            passwordcorrect = false;
                        }


                        //  if (isbrugerallredeoprret(Password, path)) // ændre 
                        // {
                        //    Console.WriteLine("BrugerNavn findes allerede");


                        // }



                    }

                    Console.WriteLine("");
                    Console.WriteLine("Godkendt password");
                    Console.WriteLine("Bruger oprettet");
                    Console.WriteLine("");
                   
                   
                    islogin_or_created_account = true;
                    //  File.WriteAllText(path, Password);
                    File.AppendAllText(path, Password);
                    File.AppendAllText(path, brugernavn);



                }












           



            }

           
            // CAN SHIP AND COSE THE FIRST PART 

        }
      
        private static bool CheckPasswordInFile_CheckBrugernavn_i_fil(string Password,string brugernavn, string path)
        {

            string[] alllines = File.ReadAllLines(path);

            foreach (string line in alllines)
            {
                if (line.Contains(Password) && line.Contains(brugernavn))
                {
                    return true;

                }

            }
            return false;


        }
        static bool ChangePasswordInFile(string Password, string newPassword, string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
                return false;
            }

            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(Password))
                {
                    lines[i] = lines[i].Replace(Password, newPassword);
                    File.WriteAllLines(path, lines);
                    return true;
                }
            }
            
            return false;
        }
        static bool CheckCredentials(string brugernavn, string Password, string newPassword)
        {
            return brugernavn.ToLower() != Password.ToLower();
        }
        static bool CheckCredentialse_kunpassword(string brugernavn, string Password)
        {
            return brugernavn.ToLower() != Password.ToLower();
        }
        

        
        /*
        private static bool isbrugerallredeoprret(string Password, string path)
        {

            string[] alllinjes2 = File.ReadAllLines(path);

            foreach (string line in alllinjes2)
            {
                if (line.Contains(Password))
                {
                    return true;
                }

            }
        */
        //   return false;

    }

}















    
