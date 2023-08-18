// 1 Faça um algoritmo que leia 10 salários. Depois de lidos e armazenados, mostre o maior valor. Utilize vetores.

double[] salarios = new double[10];
double maiorSalario;
for (int i = 0; i < salarios.Length; i++)
{
    Console.WriteLine($"Entre com o valor{i+1} do salário");
    salarios[i] = Convert.ToDouble(Console.ReadLine());
}
maiorSalario = salarios[0];
for (int i = 0; i < salarios.Length; i++)
{
    if (salarios[i] > maiorSalario)
    {
        maiorSalario = salarios[i];

    }
}
Console.WriteLine($"O maior salário digitado é R${maiorSalario}");