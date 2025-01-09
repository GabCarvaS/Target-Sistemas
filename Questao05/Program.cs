namespace Questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            var original = "Esse texto está na ordem correta";
            
            var invertida = InverterString(original);

            Console.WriteLine($"String original: {original}");
            Console.WriteLine($"String invertida: {invertida}");
        }

        static string InverterString(string input)
        {
            char[] caracteres = new char[input.Length];
            var j = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                caracteres[j] = input[i];
                j++;
            }

            return new string(caracteres);
        }
    }
}
