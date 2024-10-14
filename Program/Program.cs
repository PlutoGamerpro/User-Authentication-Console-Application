namespace User_Authentication_Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Password.Password_System();

            bool login_have_account = Password.islogin_or_created_account;

            string option;
            bool retry = true;
            string keypresed;


            if (login_have_account)
            {
                while (retry == true)
                {
                    // skal være det første program som gøres
                    Console.Write("Hvilken Program vil du starte up Fodbold Eller DanseKourrence: ");
                    option = Console.ReadLine().ToLower();
                    Console.WriteLine("");



                    if (option.ToLower() == "fodbold") { FodboldKourrence.fodbold(); }

                    else { DanseKonkurrence.danseprogram(); }
                    Console.WriteLine("");


                    Console.WriteLine("Tryk key  Q for afslutning af programmet, tryk alt andet for restart, ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);


                    if (keyInfo.Key == ConsoleKey.Q)
                    {
                        Environment.Exit(0); // Exit the program
                    }
                    else
                    {
                        retry = true;
                    }

                }
            }
        }
    }
}