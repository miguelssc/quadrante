Console.WriteLine("- Quadrante -");

 

Console.WriteLine("Digite as coordenadas para serem localizadas no quadrante. ");

Console.WriteLine("Digite a coordenada X..... ");

double coordenadax = Convert.ToDouble(Console.ReadLine());

 

Console.WriteLine("Agora digite a coordenada y..... ");

double coordenaday = Convert.ToDouble(Console.ReadLine());

 

if (coordenadax > 0 && coordenaday > 0)

{

Console.WriteLine($"O ponto ({coordenadax}, {coordenaday}) fica no primeiro quadrante. (I)");

}

else if (coordenadax > 0 && coordenaday < 0)

{

Console.WriteLine($"O ponto ({coordenadax}, {coordenaday}) fica no quarto quadrante. (IV)");

}

else if (coordenadax < 0 && coordenaday > 0)

{

Console.WriteLine($"O ponto ({coordenadax}, {coordenaday}) fica no segundo quadrante. (II)");

}

else if (coordenadax < 0 && coordenaday < 0)

{

Console.WriteLine($"O ponto ({coordenadax}, {coordenaday}) fica no terceiro quadrante. (III)");

}

else

{

Console.WriteLine($"O ponto ({coordenadax}, {coordenaday}) fica na origem do quadrante.");

}

