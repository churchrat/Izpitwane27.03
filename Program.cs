namespace Izpitvane2703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ocenki = new int[26];
            EnteringGrade(ocenki);
            Console.WriteLine(string.Join(", ",ocenki));
            Console.WriteLine("Моята оценка e " + ocenki[15]);
            GradeTwo(ocenki);
            Console.WriteLine($"Полседен елемент на масива е {ocenki[ocenki.Length-1]}");
            Console.WriteLine($"Оценките по малки от моята са {string.Join(" ,",GradeLower(ocenki))}");
            Console.WriteLine($"Има {GradeBigger(ocenki)} човека с по-големи оценки от моята");
            Console.WriteLine($"Средно аретметично на средните елементи е {Middle(ocenki)}");
            ocenki[15] = 6;
            Console.WriteLine(MyName());
        }
        static void EnteringGrade(int[] grade)
        {
            for (int i = 0; i < grade.Length/2; i++)
            {
                Console.WriteLine($"Оценката на {i+1} номер е:");
                grade[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Оценката на {16} номер е:");
            grade[15] = int.Parse(Console.ReadLine());
        }
        static void GradeTwo(int[] grade)
        {
            for(int i = 0;i < grade.Length;i++)
            {
                if (grade[i] >= 2 && grade[i]<3)
                {
                    Console.WriteLine($"Номер {i+1} има двойка!!! ");
                }
            }
        }
        static List<int> GradeLower(int[] grade)
        {
            List<int> lowergrades = new List<int>();
            for (int i = 0; i < grade.Length; i++)
            {
                if (grade[i] >= 2 && grade[i] < grade[15])
                {
                    lowergrades.Add(grade[i]);
                }
            }
            return lowergrades;
        }
        static int GradeBigger(int[] grade)
        {
            int count = 0;
            for (int i = 0; i < grade.Length; i++)
            {
                if (grade[i] <= 6 && grade[i] > grade[15])
                {
                    count++;
                }
            }
            return count;
        }
        static int Middle(int[] grades)
        {
            int sum = 0;
            int middle = grades.Length/2;
            int count = 0;
            if (grades.Length%2 == 0)
            {
                sum += grades[middle];
                sum += grades[middle+1];
                count = 2;
            }
            else
            {
                sum += grades[middle];
                sum += grades[middle + 1];
                sum += grades[middle - 1];
                count = 3;
            }
            return sum/count;
        }
        static string MyName()
        {
            string name = Console.ReadLine();
            string newName = name.Replace('i', '#');
            return newName;
        }
    }
}
