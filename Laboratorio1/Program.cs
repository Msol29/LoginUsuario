//Dado el siguiente codigo:
// string usuario= "Pepito", clave "1234";
//Informar los siguientes casos:
// Si usuario = "pepito" y clave "1234" informar Bienvenido pepito!"
// Si usuario = "pepito" y clave no es "1234" informar "Clave Incorrecta"
// Si usuario = no es "pepito" informar "usuario no existe"

string usuario="pepito", clave="1234";

if (usuario == "pepito")
{ 
    if (clave == "123456")

        Console.WriteLine("Bienvenido Pepito!");
    else
        Console.WriteLine("Clave Incorrecta");
}
else
    Console.WriteLine ("Usuario no existe");