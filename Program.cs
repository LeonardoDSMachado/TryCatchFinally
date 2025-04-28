
try
{
    Console.WriteLine("Digite seu nome\n");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite sua idade\n");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade < 0)
    {
        throw new ArgumentException("A idade não pode ser negativa");
    }
    else if (idade == 0)
    {
        throw new NotImplementedException("A idade ainda não foi definida");
    }
    else if (string.IsNullOrEmpty(nome))
    {
        throw new NullReferenceException("O nome não pode ser nulo nem vazio");
    }
    else 
    {
        Console.WriteLine("\nNome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}
catch (Exception ex)
{
    Console.WriteLine("\nErro: " + ex.Message);
}
finally
{
    Console.WriteLine("\nPrograma finalizado.");
}

Console.ReadKey();