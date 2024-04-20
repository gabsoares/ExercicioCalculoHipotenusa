double cateto1, cateto2, hipotenusa;

Console.Write("Digite o valor do primeiro cateto: ");
cateto1 = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do segundo cateto: ");
cateto2 = double.Parse(Console.ReadLine());
hipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));

Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");
