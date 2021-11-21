// See https://aka.ms/new-console-template for more information

const string SENHA = "1234abcd";
string senhaDigitada,acesso;

Console.Write("Olá usuário, digite a sua senha: ");
senhaDigitada = Console.ReadLine();

acesso = senhaDigitada == SENHA ? "Permitido":"Negado";

if(senhaDigitada == SENHA){
    Console.WriteLine($"OK. Acesso {acesso}.");
}else{
    Console.WriteLine($"Lamentamos. Acesso {acesso}.");
}

