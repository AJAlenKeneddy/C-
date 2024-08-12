using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();
Console.WriteLine($"Tu contraseña segura es {password}");