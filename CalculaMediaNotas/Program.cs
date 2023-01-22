using System.Diagnostics;

namespace MediaDeNotas
{
    class programa
    {
        static void Main(String[] args)
        {
            string N = "";
            float G1 = 0;
            float G2 = 0;
            float G3 = 0;
            float G4 = 0;
            float M = 0;
            Console.Write("Nome completo do aluno: ");
            N = Console.ReadLine();
            Console.Write("Nota do aluno no 1° bimestre: ");
            G1 = float.Parse(Console.ReadLine());
            Console.Write("Nota do aluno no 2° bimestre: ");
            G2 = float.Parse(Console.ReadLine());
            Console.Write("Nota do aluno no 3° bimestre: ");
            G3 = float.Parse(Console.ReadLine());
            Console.Write("Nota do aluno no 4° bimestre: ");
            G4 = float.Parse(Console.ReadLine());
            M = (G1 + G2 + G3 + G4) / 4;

            if (M > 6)
            {
                Console.WriteLine("O aluno " + N + " Foi aprovado. \n Sua média final foi " + M);
            }
            else
            {
                Console.WriteLine("O aluno " + N + " Foi Reprovado. \n Sua nota final foi " + M);
            }
            Console.ReadLine();
        }
    }
}