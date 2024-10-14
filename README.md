# 🎉 Welcome to the 3 Cases Project! 🎉

 Welcome to the **3 Cases** project, a fun and interactive program where you can manage user accounts, log in 🔑, and explore exciting activities ⚽️💃 like Football and Dance Competitions! 
 Let the adventure begin! 🚀
## 📝 Features

- **Account Management**: Create a new account, log in, or change your password securely.
- **Football Challenge**: Track how many passes were made and get some fun feedback!
- **Dance Competition**: Enter dancer names and their scores to see combined results!

## 🚀 Getting Started

1. **Log In**: First, you'll need to log in to your account. If you don’t have one, you can create a new account right from the menu!
2. **Choose an Activity**: After logging in, you can choose between Football and Dance activities.
3. **Enjoy**: Dive into the fun and see what happens based on your input!

## 💡 How to Run

To run this program, simply clone the repository, navigate to the project folder, and execute the following command:

```bash
dotnet run
```
## 🏛️ Defining the Main Class
- 🏛️ Defining the Main Class: This is the entry point of the program. Everything begins execution from the Main method.
 ```csharp
class Program
{
    static void Main(string[] args)
    {
        // Code will go here
    }
}
```
## 📚 User Accounts Dictionary:
- 📚 User Accounts Dictionary: We define a dictionary to store user accounts, where the key is the username and the value is the password. This allows quick lookups when users log in.  
 ```csharp
Dictionary<string, string> userAccounts = new Dictionary<string, string>();
```
  

## 📝 User Registration:
- User Registration: This method prompts the user to enter a username and password, then stores these details in the userAccounts dictionary. A success message is displayed afterward.
 ```csharp
static void Register()
{
    Console.WriteLine("Enter username:");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();
    
    // Store the username and password
    userAccounts[username] = password;
    Console.WriteLine("Registration successful! 🎉");
}
```
## 🔐 User Login:
- User Login: This method checks the credentials entered by the user against the stored values in the dictionary. If they match, the user is granted access; otherwise, an error message is shown.
```csharp
static void Login()
{
    Console.WriteLine("Enter username:");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();

    // Check if the username exists and password matches
    if (userAccounts.ContainsKey(username) && userAccounts[username] == password)
    {
        Console.WriteLine("Login successful! 🎊");
        // Proceed to the main menu
    }
    else
    {
        Console.WriteLine("Invalid credentials! ❌");
    }
}
```
## 📋 Main Menu
- This method displays options for the user. Depending on the user's choice, it either calls the registration or login method, or exits the program. If an invalid choice is entered, it prompts the user to try again.
```csharp  
static void MainMenu()
{
    Console.WriteLine("Welcome to 3 Cases! Choose an option:");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Exit");
    
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Register();
            break;
        case "2":
            Login();
            break;
        case "3":
            Environment.Exit(0); // Exit the program
            break;
        default:
            Console.WriteLine("Invalid choice! Please try again. 🔄");
            MainMenu();
            break;
    }
}
```
## 🚀 Program Initialization
- 🚀 Program Initialization: The Main method calls the MainMenu method to start the program. This is where everything kicks off!
```csharp
static void Main(string[] args)
{
    MainMenu(); // Start the main menu
}


```
### Thank you for reading!

## 🧑‍🏫 **More Resources & Tutorials**

Check out these amazing resources for more information and advanced coding skills: 📚

If you're looking to deepen your understanding, here are some helpful resources you might find useful:

- 🌟 [Official Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/)
- 📚 [My Coding Tutorials on YouTube](https://www.youtube.com/@CodeByScript)
- 🚀 [Explore My Projects Here!](https://github.com/PlutoGamerpro?tab=stars)  

Feel free to explore these if you're interested! 😊
