// See https://aka.ms/new-console-template for more information


using Assignment2Jenkins;
Console.WriteLine("welcome to Jenkins login page");
LoginCredentials lc = new LoginCredentials();
Console.WriteLine( lc.Authenticate("admin","admin@123"));
