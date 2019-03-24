#define CODIGO_BUGADO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp
{
    class Program
    {
        const double pi = 3.14159;//pi
        static void Main(string[] args)
        {
            #region passado
            /*Vou iniciar com os tipos
              de dados numéricos em c#
              */
            //Isto é um outro comentário
            /*
             * int = Int32;
             * long
             * Ponto flutuante
             * float
             * double   
             * decimal
             */
            //int numero = 0;
            //long numeroLongo = 0;
            //float numeroFloat = 0;
            //float numeroFloat2 = 1.2f;
            //double numeroDouble = 2.2;
            //decimal numeroDecimal = 23.8m;
            //short numShort = 1;

            //int intSinal = -2;

            //uint intSemSinal = 1;
            //ulong longSemSinal = 0;
            //ushort shortSemSinal = 9;
            //byte b = 1;

            //double valor1 = 14.2;
            //double valor2 = 0.2;
            //double resultado;
            //resultado = valor1 + valor2;
            //double valor1 = 14.2;
            //double valor2 = 0.2;
            //double resultado;
            //resultado = valor1 + valor2;

            //boolean

            //bool ehMaior = 1 < 2;
            //Console.WriteLine(ehMaior);

            //char meuchar = 'c';
            //Console.WriteLine(meuchar);
            //string minhaString = "Takashi";
            //Console.WriteLine(minhaString);
            //const decimal pi = 3.14m;
            //Console.WriteLine(pi);
            //Console.ReadKey();

            /*Inferência de tipo*/
            //var i = 10;

            //   Console.ReadKey();
            /*Controle de fluxo de um programa*/
            //var minhaIdade = 30;
            //var idadeDoKy = 30;

            //if (minhaIdade != idadeDoKy)
            //{
            //    Console.WriteLine("Idades diferentes");
            //}
            //else
            //{
            //    Console.WriteLine("Idades Iguais");
            //}

            //switch (minhaIdade)
            //{
            //    case 10:
            //        Console.WriteLine("Idade " + minhaIdade);
            //        break;
            //    case 24:
            //        Console.WriteLine("Idade " + minhaIdade);
            //        break;
            //    case 32:
            //        Console.WriteLine("Idade " + minhaIdade);
            //        break;
            //    default:
            //        Console.WriteLine("Caso default");
            //        break;
            //}

            /*Estruturas de repetição*/

            //string[] nomes = {"Osmar","Isaac","Ky","João","Maria"};
            //var osmar = nomes[0];
            //var tamanhoArray = nomes.Length;
            //for (int i = tamanhoArray -1; i >= 0; i--)
            //{
            //    Console.WriteLine(nomes[i]);
            //}

            //int[] numeros = new int[5];
            //numeros[0] = 1;
            //numeros[1] = 2;
            //numeros[2] = 2;
            //numeros[3] = 3;
            //numeros[4] = 4;
            //numeros[5] = 5;
            //numeros[6] = 6;

            //foreach (var nome in nomes)
            //{
            //    Console.WriteLine(nome);
            //}

            //int index = 0;
            //while (index < 10)
            //{
            //    Console.WriteLine("Olá");
            //    index++;
            //}

            //var iwhile = 0;
            //do
            //{
            //    Console.WriteLine("Olá");
            //    iwhile++;
            //} while (iwhile < 0); 
            #endregion

            /*Comandos goto, break, continue, return*/

            //#region goto
            //int x = 200, y = 4;
            //int count = 0;
            //string[,] array = new string[x, y];

            //// Initialize the array:
            //for (int i = 0; i < x; i++)

            //    for (int j = 0; j < y; j++)
            //        array[i, j] = (++count).ToString();

            //// Read input:
            //Console.Write("Enter the number to search for: ");

            //// Input a string:
            //string myNumber = Console.ReadLine();

            //// Search:
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if (array[i, j].Equals(myNumber))
            //        {
            //            goto Found;
            //        }
            //    }
            //}

            //Console.WriteLine("The number {0} was not found.", myNumber);
            //goto Finish;

            //Found:
            //Console.WriteLine("The number {0} is found.", myNumber);

            //Finish:
            //Console.WriteLine("End of search.");


            //// Keep the console open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            //#endregion

            #region break

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //// Keep the console open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            #endregion

            #region Continue

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i < 9)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //// Keep the console open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            #endregion

            /*OPERADORES*/
            //adição +
            //subtração -
            //multiplicação *
            //divisão /

            /*Operadores lógicos*/
            // > < >= <= != ==

            //int a = 3, b = 2, c = 0;
            //c = a + b;
            //c = a - b;
            //c = a * b;
            //c = c / 2;
            //bool teste = a > b;
            //teste = b < c;

            // Console.WriteLine($"O valor de c é : {c}");

            //Console.WriteLine("O valor de c é : " + c);
            //Console.WriteLine(string.Concat("O valor de c é: ",c));

            /*
             * Faça um algoritmo para calcular a área de uma
             * circunferência, considerando a fórmula ÁREA = π * RAIO2 .
             * Utilize as variáveis AREA e RAIO, a constante π (pi = 3,14159)
             * e os operadores aritméticos de multiplicação.
             */

            //double area = 0;// resultado esperado
           
            //double raio = 0;//valor de entrada
            //Console.WriteLine("Informe o valor do raio:\n\n");
            //raio = Convert.ToDouble(Console.ReadLine());

            //area = CalcularAreaCircunferencia(raio);

            //Console.WriteLine($"O valor da area é: {area}");            //double area = 0;// resultado esperado
           
            //double raio = 0;//valor de entrada
            //Console.WriteLine("Informe o valor do raio:\n\n");
            //raio = Convert.ToDouble(Console.ReadLine());

            //area = CalcularAreaCircunferencia(raio);

            //Console.WriteLine($"O valor da area é: {area}");

            //double area = 0, @base = 4, altura = 3;
            //area = ((@base * altura) / 2);
            var calculador = new Calculadora();
            var area2 = calculador.CalcularAreaCircunferencia(5);
            var referencia = new Referencia();
            referencia.ValorB = 5;
            referencia.ValorA = 3;
            calculador.CalcularQualquerCoisa(referencia);

            int valorA = 2, valorB = 3;
            //passagem de parametro por valor
            calculador.AlterarValores(valorA, valorB);

            //passagem de parametro por referencia
            calculador.AlterarValoresReferencia(ref valorA,ref valorB);
            var coord = new Coordenadas();
            coord.Latitude = 2.3;
            coord.Longitude = 3.4;

            





        }

        /// <summary>
        /// Este método calcula a área de uma circunferência
        /// </summary>
        /// <param name="raio"></param>
        /// <returns></returns>
        private static double CalcularAreaCircunferencia(double raio)
        {
            double area;
            area = pi * (Math.Pow(raio, 2));
            return area;
        }
    }


}


