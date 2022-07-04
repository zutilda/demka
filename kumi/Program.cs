/*
//коммивояжер
namespace ConsoleApp2 // Note: actual namespace depends on the project name.
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Для начала работы введиите 1");
                Console.WriteLine("Для завершения работы введиите 2");
                Console.WriteLine("Для начала работы с ручным вводом значений введиите 3");
                int f = Convert.ToInt32(Console.ReadLine());
                bool v = false;
                switch (f)
                {
                    case 1:
                        double[,] vs = {
                //{0,15,26,52,29,24},
                //{13,0,28,28,19,15},
                //{24,13,0,14,19,30},
                //{46,55,35,0,20,65},
                //{23,15,15,28,0,40},
                //{35,16,14,10,12,0 }

                {0,1,2,3,5},
                {1,0,4,4,3},
                {2,4,0,1,2},
                {7,4,1,0,3},
                {5,3,2,3,0}

                // {0,15,12,24,19},
                //{6,0,25,30,50},
                //{25,15,0,12,15},
                //{20,10,10,0,15},
                //{15,20,10,11,0}
                };
                        int g = 5;
                        resh(vs, g);
                        break;

                    case 2:
                        v = true;
                        break;
                    case 3:
                        Console.WriteLine("Введите размерность:");
                        int g1 = 3;
                        g1 = Convert.ToInt32(Console.ReadLine());
                        double[,] vs1 = new double[g1, g1];
                        for (int i = 0; i < g1; i++)
                        {
                            for (int j = 0; j < g1; j++)
                            {
                                vs1[i, j] = Convert.ToDouble(Console.ReadLine());
                            }
                        }
                        resh(vs1, g1);
                        break;


                }

                if (v)
                {
                    break;
                }
            }

        }
        public static void resh(double[,] vs, int g)
        {
            List<List<int>> f1 = new List<List<int>>();
            List<double> t = new List<double>();

            for (int n = 0; g != n; n++)
            {
                List<List<int>> f = new List<List<int>>();
                List<int> list = new List<int>();
                f.Clear();
                f.Add(list);
                list.Add(n);

                while (f[0].Count <= g)
                {

                    List<List<int>> z = new List<List<int>>();


                    for (int k = 0; k < f.Count; k++)
                    {
                        List<int> listic = new List<int>();
                        for (int i = 0; i < g; i++)
                        {
                            listic.Add(i);
                        }
                        for (int i = f[k].Count - 1; i >= 0; i--)
                        {
                            listic.Remove(f[k][i]);


                        }
                        double max = double.MaxValue;
                        List<int> vs1 = new List<int>();


                        for (int i = 0; i < listic.Count; i++)
                        {
                            if (f[k].Last() == listic[i])
                            {
                                continue;
                            }
                            double kl = vs[f[k].Last(), listic[i]];
                            if (max >= kl)
                            {
                                max = kl;
                                vs1.Add(listic[i]);
                            }

                        }
                        z.Add(new List<int>(vs1.ToArray()));
                    }
                    bool ret = true;
                    int x = f.Count;
                    for (int k = 0; k < x; k++)
                    {
                        if (f[k].Count == g)
                        {
                            f[k].Add(f[k].First());
                            continue;
                        }
                        for (int i = 0; i < z[k].Count - 1; i++)
                        {
                            if (z[k].Count == 0)
                            {
                                continue;
                            }
                            if (vs[f[k].Last(), z[k][i]] == vs[f[k].Last(), z[k].Last()])
                            {
                                f.Add(new List<int>(f[k].ToArray()));
                                f[f.Count - 1].Add(z[k][i]);
                            }
                        }
                        f[k].Add(z[k].Last());

                    }



                }

                for (int i = 0; i < f.Count; i++)
                {
                    double fun = 0;
                    for (int h = 0; h < f[i].Count - 1; h++)
                    {


                        fun += vs[f[i][h], f[i][h + 1]];


                    }
                    t.Add(fun);
                }
                for (int i = 0; i < f.Count; i++)
                {
                    f1.Add(f[i]);
                }

            }
            for (int i = 0; i < f1.Count; i++)
            {
                for (int j = 0; j < f1[i].Count; j++)
                {
                    Console.Write(f1[i][j] + 1);
                }
                Console.WriteLine("  Длинна маршрута = " + t[i]);
            }
            List<int> fi = new List<int>();
            for (int i = 0; i < f1.Count - 1; i++)
            {
                if (t[i] == t.Min())
                {
                    fi.Add(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Самый короткий маршрут");
            for (int i = 0; i < fi.Count; i++)
            {
                for (int j = 0; j < f1[i].Count; j++)
                {
                    Console.Write(f1[fi[i]][j] + 1);
                }
                Console.WriteLine("  Длинна маршрута = " + t[fi[i]]);
            }
        }
    }
}
*/







/*
// критический путь
using System;

namespace Indexs
{
    class program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Дана таблица работ для сетевого графика. Построить сетевой график и найти критический путь.");
            
                int[] ri = new int[] { 1, 1, 1, 2, 2, 3, 4 }; // начало пути 
                int[] rj = new int[] { 2, 3, 5, 3, 4, 4, 5 }; // конец пути 
                int[] dij = new int[ri.Length]; // объявление масива 

            m1: int otv = 0;
                while (true)
                {
                    Console.Write($"Введите номер способа заполнения продолжительностей работ\n1.Вручную\n2.Рандомно\nОтвет: ");
                    try
                    {
                        otv = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введено некорректное значение! Повторите ввод");
                    }

                }

                switch (otv) // выбор ручного или автоматического заполнения 
                {
                    case 1:
                        int a = 0;
                        for (int i = 0; i < dij.Length; i++)
                        {
                            while (true) // проверка введенного значения 
                            {
                                Console.Write($"Ввдеите продолжительность {i + 1} работы: "); // ввод продолжительности работ 
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    dij[i] = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"Введено некорректное значение! Повторите ввод.");
                                }
                            }
                        }
                        break;
                    case 2:
                        Random rnd = new Random();
                        for (int i = 0; i < dij.Length; i++) // рандомное заполнение 
                        {
                            dij[i] = rnd.Next(1, 100);
                        }
                        break;
                    default:
                        Console.WriteLine($"Введено некорректное значение! Повторите ввод.");
                        goto m1;
                        break;
                }

                Console.Clear();

                Console.WriteLine($"Работы и их продолжительность:");
                for (int i = 0; i < dij.Length; i++)
                {
                    Console.WriteLine($"{ri[i]}-{rj[i]}({dij[i]})");  // вывод таблицы 
                }

                Console.WriteLine();

                int[,] table = new int[4, 5];

                int[][] pathes = new int[4][]; // массив из массивов (ступенчатый массив)
                pathes[0] = new int[5];
                pathes[1] = new int[6]; // пути , одна ячейка для F
                pathes[2] = new int[5];
                pathes[3] = new int[3];

                for (int i = 0; i < ri.Length; i++)
                {
                    table[ri[i] - 1, rj[i] - 1] = dij[i];  // заполнение таблицы с продолжительностями в днях 
                }

                pathes[0][0] = 1;
                pathes[0][1] = 2; // пути заполняются 
                pathes[0][2] = 4;
                pathes[0][3] = 5;

                pathes[1][0] = 1;
                pathes[1][1] = 2;
                pathes[1][2] = 3;
                pathes[1][3] = 4;
                pathes[1][4] = 5;

                pathes[2][0] = 1;
                pathes[2][1] = 3;
                pathes[2][2] = 4;
                pathes[2][3] = 5;

                pathes[3][0] = 1;
                pathes[3][1] = 5;

                for (int j = 0; j < pathes.Length; j++) // перебирает массивы внутри массива
                {
                    for (int i = 1; i < pathes[j].Length - 1; i++) // перебирает элементы конкретного массива 
                    {
                        pathes[j][pathes[j].Length - 1] += table[pathes[j][i - 1] - 1, pathes[j][i] - 1]; // обращаемся к последнему элементу массива и плюсуем значение пути
                    }
                }

                for (int j = 0; j < pathes.Length; j++)// перебират массивы внутри массива 
                {
                    Console.Write($"Путь {j + 1}: "); // выводит путь индекс пути 
                    for (int i = 0; i < pathes[j].Length - 1; i++) // последняя f его не выводим 
                    {
                        if (i == pathes[j].Length - 2)
                        {
                            Console.Write($"{pathes[j][i]}");
                        }
                        else
                        {
                            Console.Write($"{pathes[j][i]}-");
                        }

                    }
                    Console.WriteLine($"; F = {pathes[j][pathes[j].Length - 1]}"); // вывод f
                }

                int MaxF = int.MinValue; /// для поиска максимального f
                int ind = 0; // индекс максимального пути 

                for (int i = 0; i < pathes.Length; i++)
                {
                    if (MaxF < pathes[i][pathes[i].Length - 1])
                    {
                        MaxF = pathes[i][pathes[i].Length - 1];
                        ind = i;
                    }
                }

                Console.Write($"Критический путь - Путь {ind + 1}: ");//вывод критического пути и его индекс 
                for (int i = 0; i < pathes[ind].Length - 1; i++)
                {
                    if (i == pathes[ind].Length - 2)
                    {
                        Console.Write($"{pathes[ind][i]}");
                    }
                    else
                    {
                        Console.Write($"{pathes[ind][i]}-");
                    }

                }
                Console.WriteLine($"; F = {pathes[ind][pathes[ind].Length - 1]}");
                while (true)
                {
                    Console.Write($"Хотите повторить выполнение программы ? (0 - нет, любая цифра - да)");
                    try
                    {
                        otv = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введено некорректное значение! Повторите ввод");
                    }

                }
                if (otv == 0)
                {
                    break;
                }
            }
        }
        
    }
}
 */








/*
// критический путь 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafs
{
    internal class 
    {
        static void Main(string[] args)
        {
            string reponse = "Кратчайший путь ";
            int answer = 0;
            Console.Write("Введите расстояние от 1 до 2: ");
            int one_two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 1 до 3: ");
            int one_three = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 1 до 4: ");
            int one_four = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 2 до 5: ");
            int two_five = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 2 до 6: ");
            int two_six = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 3 до 5: ");
            int three_five = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 3 до 6: ");
            int three_six = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 4 до 5: ");
            int four_five = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 4 до 6: ");
            int four_six = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 5 до 7: ");
            int five_seven = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 5 до 8: ");
            int five_eight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 5 до 9: ");
            int five_nine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 6 до 7: ");
            int six_seven = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 6 до 8: ");
            int six_eight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 6 до 9: ");
            int six_nine = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 7 до 10: ");
            int seven_ten = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 8 до 10: ");
            int eight_ten = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расстояние от 9 до 10: ");
            int nine_ten = Convert.ToInt32(Console.ReadLine());
            if (one_two < one_three && one_two < one_four)
            {
                reponse += " 1 --> 2 --> ";
                answer += one_two;
                if (two_five < two_six)
                {
                    reponse += "5 --> ";
                    answer += two_five;
                    if (five_seven < five_eight && five_seven < five_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (five_eight < five_seven && five_eight < five_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (five_nine < five_seven && five_nine < five_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
                else if (two_six < two_five)
                {
                    reponse += "6 --> ";
                    answer += two_six;
                    if (six_seven < six_eight && six_seven < six_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (six_eight < six_seven && six_eight < six_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (six_nine < six_seven && six_nine < six_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
            }
            else if (one_four < one_two && one_four < one_three)
            {
                reponse += " 1 --> 4 --> ";
                answer += one_four;
                if (four_five < four_six)
                {
                    reponse += "5 --> ";
                    answer += four_five;
                    if (five_seven < five_eight && five_seven < five_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (five_eight < five_seven && five_eight < five_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (five_nine < five_seven && five_nine < five_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
                else if (four_six < four_five)
                {
                    reponse += "6 --> ";
                    answer += four_six;
                    if (six_seven < six_eight && six_seven < six_nine)
                    {
                        reponse += "7 -->1 0";
                        answer += five_seven += seven_ten;
                    }
                    else if (six_eight < six_seven && six_eight < six_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (six_nine < six_seven && six_nine < six_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
            }
            else if (one_three < one_four && one_three < one_two)
            {
                reponse += " 1 --> 3 --> ";
                answer += one_three;
                if (three_five < three_six)
                {
                    reponse += "5 --> ";
                    answer += three_five;
                    if (five_seven < five_eight && five_seven < five_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (five_eight < five_seven && five_eight < five_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (five_nine < five_seven && five_nine < five_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
                else if (three_six < three_five)
                {
                    reponse += "6 --> ";
                    answer += three_six;
                    if (six_seven < six_eight && six_seven < six_nine)
                    {
                        reponse += "7 --> 10";
                        answer += five_seven += seven_ten;
                    }
                    else if (six_eight < six_seven && six_eight < six_nine)
                    {
                        reponse += "8 --> 10";
                        answer += five_eight += eight_ten;
                    }
                    else if (six_nine < six_seven && six_nine < six_eight)
                    {
                        reponse += "9 --> 10";
                        answer += five_nine += nine_ten;
                    }
                }
            }
            Console.WriteLine($"\n {reponse} = {answer}");
            Console.ReadKey();
        }
    }
}
 */







/*
// симплекс метод
using System;

namespace Симплекс_м
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int r=0, c=0;//размерности матрицы и векторов
                while (true)//ввод количество вида сырья(размерности по стокам)
                {
                    try
                    {
                        Console.WriteLine("Введите количество вида сырья");
                        r = Convert.ToInt32(Console.ReadLine());
                        if (r < 2)
                        {
                            Console.WriteLine("Видов сырья должно быть не менее двух! Повторите ввод");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                while (true)//ввод потребителей(размерности по столбцам)
                {
                    try
                    {
                        Console.WriteLine("Введите количество видов продукции");
                        c = Convert.ToInt32(Console.ReadLine());
                        if (c < 2)
                        {
                            Console.WriteLine("Количество видов продукции должно быть не менее двух! Повторите ввод");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                int i = 0, j = 0;//переменные для циклов
                int[,] matrxA = new int[r, c];//таблица без запасов сырья
                Console.WriteLine("Ввод таблицы затрат на перевозку продукции:");//ввод данных в таблицу расходов ресурсов
                for (i = 0; i < matrxA.GetLength(0); i++)
                {
                    for (j = 0; j < matrxA.GetLength(1); j++)
                    {

                        while (true)
                        {
                            try
                            {
                                Console.Write($"Введите расход  {i + 1} сырья  для {j + 1} единицы продукции: ");
                                matrxA[i, j] = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Введены некорректные данные!");
                            }
                        }

                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Таблица расхода сырья на единицу продукции вида:");//вывод таблицы  на экран
                for (i = 0; i < matrxA.GetLength(0); i++)
                {
                    for (j = 0; j < matrxA.GetLength(1); j++)
                    {
                        Console.Write(matrxA[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                char otv;
                int temp;//переменная для диалога с пользователем
                         //Изменение матрицы
                while (true)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("\nХотите изменить данные о таблице?\nДа(любая клавиша)/Нет(N)\nОтвет: ");
                            otv = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Введены некорректные данные!");
                        }
                    }
                    if (otv.Equals('n') || otv.Equals('т') || otv.Equals('N') || otv.Equals('Т'))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Введите номер вида сырья, затем номер вида ресурса, который вы хотите изменить\nОтвет:\n");
                        while (true)
                        {
                            i = Convert.ToInt32(Console.ReadLine());
                            j = Convert.ToInt32(Console.ReadLine());
                            if (i < c + 1 && j < r + 1)
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("Введите новое значение: ");
                                        temp = Convert.ToInt32(Console.ReadLine());
                                        if (temp != 0)
                                        {
                                            Console.WriteLine($" Была изменена {i} {j} ячейка таблицы c {matrxA[i - 1, j - 1]} на {temp}");
                                            matrxA[i - 1, j - 1] = temp;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы ввели нулевое значение! Повторите ввод");
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Введены некорректные данные!");
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введенная размерность не соответствует матрице! Повторите ввод");
                            }
                        }
                    }
                }

                Console.Clear();
                int[] m = new int[r];//вектор
               
                Console.WriteLine("Ввод данных о затратах сырья:");//ввод данных в вектор мощности поставщиков
                for (i = 0; i < m.Length; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Введите затраты сырья {i + 1} вида: ");
                            m[i] = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Введены некорректные данные!");
                        }
                    }
                }

                Console.WriteLine("Вектор затрат сырья:");//вывод на экран
                for (i = 0; i < m.Length; i++)
                {
                    Console.WriteLine($"{m[i]} ");
                }

                int[] d = new int[r];//вектор
               


                Console.WriteLine("Введите  доход:");
                for (i = 0; i < c; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Введите доход продукции {i + 1} вида: ");
                            d[i] = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Введены некорректные данные!");
                        }
                    }
                }

               
                Console.WriteLine("Вектор дохода:");//вывод на экран
                for (i = 0; i < m.Length; i++)
                {
                    Console.WriteLine($"{d[i]} ");
                }


                Console.WriteLine("\nТаблица:");//вывод на экран матрицы и векторов
                Console.Write("  ");

                Console.WriteLine();
                for (i = 0; i < matrxA.GetLength(0); i++)
                {
                    Console.Write($"{m[i]} ");
                    for (j = 0; j < matrxA.GetLength(1); j++)
                    {
                        Console.Write($"{matrxA[i, j]} ");
                    }
                    Console.WriteLine();
                }
                for ( i = 0; i < d.Length; i++)
                {
                    Console.Write($"{d[i]} ");
                }

                double[,] simpleks = new double[r + 1, c + 1 + r];
                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        simpleks[i, j] = matrxA[i, j];
                    }
                }
                for (i = 0; i < d.Length; i++)
                {
                    simpleks[simpleks.GetLength(0) - 1, i] = d[i];
                }
                for (i = 0; i < m.Length; i++)
                {
                    simpleks[i, simpleks.GetLength(1)-1] = m[i];
                }
                int l = 0;
                for (i = c; i < c + r; i++)
                {
                    simpleks[l++, i] = 1;
                }
                Console.WriteLine("\nCимплекс таблица:");
                for (i = 0; i < simpleks.GetLength(0); i++)
                {
                    for (j = 0; j < simpleks.GetLength(1); j++)
                    {
                        Console.Write($"{simpleks[i, j]} "); 
                    }
                    Console.WriteLine();
                }

                double[] b = new double[0];
                int  temp2 = 0;
                for ( j = 0; j < simpleks.GetLength(1) - 1; j++)
                {
                    temp = 0;
                    temp2 = 0;
                    for ( i = 0; i < simpleks.GetLength(0) - 1; i++)
                    {
                        if (simpleks[i, j] == 0)
                            temp++;
                        if (simpleks[i, j] == 1)
                            temp2++;
                    }
                    if (temp == simpleks.GetLength(0) - 2 && temp2 == 1)
                    {
                        for ( i = 0; i < simpleks.GetLength(0) - 1; i++)
                        {
                            if (simpleks[i, j] == 1)
                            {
                                temp = i;
                            }
                        }
                        Array.Resize(ref b, b.Length + 1);
                        b[b.Length - 1] = Math.Round(simpleks[temp, simpleks.GetLength(1) - 1]);
                    }
                    else
                    {
                        Array.Resize(ref b, b.Length + 1);
                        b[b.Length - 1] = 0;
                    }
                   
                }
                for ( i = 0; i < b.Length; i++)
                {
                    Console.WriteLine($"x{i + 1} = {b[i]}");
                    
                }
                Array.Resize(ref b, 0);
                int indexi = 0;
                int indexj = 0;
                Console.WriteLine($"F'={simpleks[simpleks.GetLength(0) - 1, simpleks.GetLength(1) - 1]}");
                Console.WriteLine($"F ={Math.Abs(simpleks[simpleks.GetLength(0) - 1, simpleks.GetLength(1) - 1])}");
                double max = double.MinValue;
                for (i = 0; i < simpleks.GetLength(1); i++)
                {
                    if (simpleks[simpleks.GetLength(0)-1, i]>max)
                    {
                        max = simpleks[simpleks.GetLength(0) - 1, i];
                        indexj = i;
                    }
                }
                double min = double.MaxValue;
                for (i = 0; i < simpleks.GetLength(0)- 1; i++)
                {
                    if (simpleks[i,simpleks.GetLength(1)-1]/simpleks[i, indexj] < min)
                    {
                        min = simpleks[i, simpleks.GetLength(1) - 1] / simpleks[i, indexj];
                        indexi = i;
                    }
                }
                Console.WriteLine($"{indexi+1}  {indexj+1}");

            }
        }
    }
}
 */











/*
// распределение с-з
using System;

namespace Программа
{
    class Program
    {
        static void GetRazmer(ref int a, string text)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Введите количество {text}: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < 2)
                    {
                        Console.WriteLine($"{text} должно быть не менее двух! Повторите ввод");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные!");
                }
            }
        }

        static void GetMatr(ref int[,] matr, int r, int c, string text)
        {
            int i = 0, j = 0;//переменные для циклов
            Console.WriteLine($"Ввод таблицы затрат на {text} продукции:");//ввод данных в таблицу затрат
            for (i = 0; i < matr.GetLength(0); i++)
            {
                for (j = 0; j < matr.GetLength(1); j++)
                {

                    while (true)
                    {
                        try
                        {
                            Console.Write($"Введите стоимость {text} от {i + 1} поставщика  к {j + 1} потребителю: ");
                            matr[i, j] = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Введены некорректные данные!");
                        }
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine($"Таблица затрат на {text} продукции:");//вывод таблицы затрат на экран
            for (i = 0; i < matr.GetLength(0); i++)
            {
                for (j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            char otv;//переменная для диалога с пользователем
            //Изменение матрицы
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("\nХотите изменить данные о таблице?\nДа(любая клавиша)/Нет(N)\nОтвет: ");
                        otv = Convert.ToChar(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                if (otv.Equals('n') || otv.Equals('т') || otv.Equals('N') || otv.Equals('Т'))
                {
                    break;
                }
                else
                {
                    Console.Write("Введите номер поставщика, нажмите Enter, затем номер потребителя, который вы хотите изменить\nОтвет:\n");
                    while (true)
                    {
                        i = Convert.ToInt32(Console.ReadLine());
                        j = Convert.ToInt32(Console.ReadLine());
                        if (i < c + 1 && j < r + 1)
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.Write("Введите новое значение: ");
                                    int temp = Convert.ToInt32(Console.ReadLine());
                                    if (temp != 0)
                                    {
                                        Console.WriteLine($" Была изменена {i} {j} ячейка таблицы c {matr[i - 1, j - 1]} на {temp}");
                                        matr[i - 1, j - 1] = temp;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели нулевое значение! Повторите ввод");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Введены некорректные данные!");
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введенная размерность не соответствует матрице! Повторите ввод");
                        }
                    }
                }
            }
        }
        static void vector(ref int[] m, int i, int j, string text)
        {
            Console.WriteLine($"Ввод данных о количестве продукции {text}:");//ввод данных в вектор мощности поставщиков
            for (i = 0; i < m.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Введите количество продукции у {i + 1} {text}: ");
                        m[i] = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
            }
        }
        static void GetVectora(ref int[] m, ref int[] n)
        {
            int i = 0, j = 0;//переменные для циклов
            int valueM = 0, valueN = 0;
            while (true)
            {
                vector(ref m, i, j, "Поставщика");
                vector(ref n, i, j, "Потребителя");
                for (i = 0; i < m.Length; i++)
                {
                    valueM += m[i];
                }
                for (i = 0; i < n.Length; i++)
                {
                    valueN += n[i];
                }
                if (valueM == valueN)
                {
                    break;
                }
                else//проверка на равенство суммы элементов векторов
                {
                    Console.WriteLine("Вектор мощности (m) и cпроса (n) должны быть равны, повторите ввод!");
                    valueM = 0;
                    valueN = 0;
                }
            }
            Console.WriteLine("Вектор мощности (m):");//вывод на экран
            for (i = 0; i < m.Length; i++)
            {
                Console.Write($"{m[i]} ");
            }
            Console.WriteLine("\nВектор спроса (n):");//вывод на экран
            for (i = 0; i < n.Length; i++)
            {
                Console.Write($"{n[i]} ");
            }
        }
        static void GetSumma(ref int[,] c, int[,] a, int[,] b) // Мктод для для заполнения массива суммы
        {
            int i = 0, j = 0;//переменные для циклов
            for (i = 0; i < c.GetLength(0); i++)
            {
                for ( j = 0; j < c.GetLength(1); j++)
                {
                    c[i,j] = a[i,j] + b[i,j];
                }
            }
            Console.WriteLine($"Матрица суммы:");// вывод матрицы суммы
            for (i = 0; i < c.GetLength(0); i++)
            {
                for (j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void GetNewMassive(ref string[,] d, int[] a, int[] b, int[,] c)
        {
            // Цикл для заполнения спросов в новом массиве
            for (int i = 0; i < b.Length; i++)
            {
                d[0, i+1] = Convert.ToString(b[i]);
            }
            // Цикл для заполнения мощностей поставщиков в новом массиве
            for (int j = 0; j < a.Length; j++)
            {
                d[j + 1, 0] = Convert.ToString(a[j]);
            }
            // Цикл для заполнения суммы массивов
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    d[i+1,j+1] = Convert.ToString(c[i,j]);
                }
            }
        }
        static int GetDistribution(ref string[,] a) //Выполнения распредления и подсчёта суммы
        {
            int summa = 0; // Переменная для хранения суммы
            for (int i = 1; i < a.GetLength(0); i++) // Цикл по строкам массива
            {
                for (int j = 1; j < a.GetLength(1); j++) // Цикл по столбцам массива
                {
                    if(Convert.ToInt32(a[0,j]) != 0) // Проверка, если в ячейке спрос равен 0, то идём дальше
                    {
                        if(Convert.ToInt32(a[i, 0]) != 0) // Проверка, если в ячейке предложение равно 0, то переходим на новую строчку
                        {
                            if (Convert.ToInt32(a[i,0]) > Convert.ToInt32(a[0,j])) // Проверка, если предложение больше спроса
                            {
                                summa = summa + Convert.ToInt32(a[i,j]) * Convert.ToInt32(a[0,j]); // К сумме прибавляем произведение цены с поставкой
                                a[i,j] = a[i,j] + " / " + a[0,j]; // В ячекй добавляем символ / и максимальную поставку
                                a[i, 0] = Convert.ToString(Convert.ToInt32(a[i, 0]) - Convert.ToInt32(a[0, j])); // Вычитаем из предложения сделанную поставку
                                a[0,j] = "0"; // Зануляем спрос, так как весь спрос удовлетворён
                            }
                            else if (Convert.ToInt32(a[i,0]) < Convert.ToInt32(a[0,j]))// Проверка, если предложение меньше спроса
                            {
                                summa = summa + (Convert.ToInt32(a[i,j]) * Convert.ToInt32(a[i,0])); // К сумме прибавляем произведение цены с поставкой
                                a[i,j] = a[i,j] + " / " + a[i,0]; // В ячекй добавляем символ / и максимальную поставку
                                a[0,j] = Convert.ToString(Convert.ToInt32(a[0,j]) - Convert.ToInt32(a[i,0])); // Вычитаем из спроса сделанную поставку
                                a[i,0] = "0"; // Зануляем предложение, так как у данного поставщика закончилась продукция
                                // Переходим на новую строку на тот же магазин
                                if(i != i - 1)
                                {
                                    i++;
                                    j--;
                                }
                            }
                            else
                            {
                                summa = summa + (Convert.ToInt32(a[i,j]) * Convert.ToInt32(a[i,0])); // К сумме прибавляем произведение цены с поставкой
                                a[i,j] = a[i, j] + " / " + a[i, 0]; // В ячекй добавляем символ / и максимальную поставку
                                a[i,0] = "0"; // Зануляем предложение, так как у данного поставщика закончилась продукция
                                a[0,j] = "0"; // Зануляем спрос, так как весь спрос удовлетворён
                                // Переходим на новую строку на тот же магазин
                                if (i != i - 1)
                                {
                                    i++;
                                    j--;
                                }
                            }
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
            }
            return summa;
        }
        static void ShowRurult(string [,] d) // метод для вывода результата
        {
            int p = 1; // Переменная хранящая номер записи
            // Циклы для прохождения по массиву распределения
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        j++;
                    }
                    string str = d[i,j]; // Переменная для хранения содержимого ячейки
                    int k = 0; // Количесво символов / в ячейке
                    int index = 0; // Переменная, которая хранит индекс символа /
                    for (int e = 0; e < str.Length; e++)
                    {
                        if (str[e] == '/')
                        {
                            k++;
                            index = e;
                        }
                    }
                    if (k != 0) // Если в ячейке есть символ /
                    {
                        // Вывод записи кому и с кем нужно заключить договор
                        Console.WriteLine(p + ") " + i + " поставщику требуется заключить договор с " + j + " магазином на поставку " + str.Substring(index + 1) + " единиц продукции\n");
                        p++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нахождение первоначального распределения транспортной задачи по метод северо-заподного угла");
                int r = 0, c = 0;//размерности матрицы и векторов
                GetRazmer(ref r, "Потребителей"); //ввод потребителей(размерности по столбцам)
                GetRazmer(ref c, "Поставщиков"); //ввод поставщиков(размерности по стокам)
                int[,] matrxA = new int[r, c];//матрица затрат перевозку единицы процукции
                int[,] matrxB = new int[r, c];//матрица затрат на хранение единицы процукции
                Console.Clear();
                GetMatr(ref matrxA, r, c, "Перевозки");
                Console.Clear();
                GetMatr(ref matrxB, r, c, "Хранения");
                Console.Clear();
                int[] m = new int[r];//вектор мощности поставщиков
                int[] n = new int[c];//вектор спроса потребителей
                GetVectora(ref m, ref n);
                Console.Clear();
                int[,] matrxC = new int[r, c];//матрица суммы матриц затрат на хранение и перевозку единицы продукции
                GetSumma(ref matrxC, matrxA, matrxB);
                string[,] matrxD = new string[r+1, c+1];//матрица для распределения с дополнительной строкой и столбцом для спроса и предложения
                GetNewMassive(ref matrxD, m, n, matrxC); // Формирование новой матрицы
                double summa; // Переменная для хранения значения целевой функции
                summa = GetDistribution(ref matrxD);
                Console.Clear();
                Console.WriteLine($"Матрица суммы:");// вывод матрицы с рапределёнными поставками
                for (int i = 0; i < matrxD.GetLength(0); i++)
                {
                    for (int j = 0; j < matrxD.GetLength(1); j++)
                    {
                        Console.Write(matrxD[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nОбщие затраты денег: " + summa + " у. д. е.");
                Console.ReadKey();
                Console.Clear();
                ShowRurult(matrxD);
                char otv; // Переменная для диалога с пользователем
                while (true)
                {
                    try
                    {
                        Console.Write("\nПовторить программу?\nДа(Y)/Нет(N)\nОтвет: ");
                        otv = Convert.ToChar(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                if (!(otv.Equals('Y') || otv.Equals('y') || otv.Equals('н') || otv.Equals('Н')))
                {
                    break;
                }
                else if (!(otv.Equals('N') || otv.Equals('N') || otv.Equals('Т') || otv.Equals('т')))
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
 */



/*
// распределение с конченной формулой (максимальный элемент +1)-начальная матрица
using System;

namespace Мат_моделирование
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Сделать первоначальное распределение по методу северо-западного угла в транспортной задаче с учетом преобразования исходной матрицы А в матрицу В по правилу:В = {mахл + 1}-А");
                uint r, c;//размерности матрицы и векторов
                while (true)//ввод потребителей(размерности по столбцам)
                {
                    try
                    {
                        Console.Write("Введите количество потребителей: ");
                        c = Convert.ToUInt32(Console.ReadLine());
                        if (c < 2)
                        {
                            Console.WriteLine("Потребителей должно быть не менее двух! Повторите ввод");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                while (true)//ввод поставщиков(размерности по стокам)
                {
                    try
                    {
                        Console.Write("Введите количество поставщиков: ");
                         r= Convert.ToUInt32(Console.ReadLine());
                        if (r < 2)
                        {
                            Console.WriteLine("Поставщиков должно быть не менее двух! Повторите ввод");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                int i = 0, j = 0;//переменные для циклов
                uint[,] matrxA = new uint[r, c];//матрица затрат
                Console.WriteLine("Ввод таблицы затрат на перевозку продукции:");//ввод данных в таблицу затрат
                for (i = 0; i < matrxA.GetLength(0); i++)
                {
                    for (j = 0; j < matrxA.GetLength(1); j++)
                    {

                        while (true)
                        {
                            try
                            {
                                Console.Write($"Введите стоимость перевозки от {i + 1} поставщика  к {j + 1} потребителю: ");
                                matrxA[i, j] = Convert.ToUInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Введены некорректные данные!");
                            }
                        }

                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Таблица затрат на перевозку продукции:");//вывод таблицы затрат на экран
                for (i = 0; i < matrxA.GetLength(0); i++)
                {
                    for (j = 0; j < matrxA.GetLength(1); j++)
                    {
                        Console.Write(matrxA[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                char otv;//переменная для диалога с пользователем
                //Изменение матрицы
                while (true)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("\nХотите изменить данные о таблице?\nДа(любая клавиша)/Нет(N)\nОтвет: ");
                            otv = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Введены некорректные данные!");
                        }
                    }
                    if (otv.Equals('n') || otv.Equals('т') || otv.Equals('N') || otv.Equals('Т'))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Введите номер поставщика, затем номер потребителя, который вы хотите изменить\nОтвет:\n");
                        while (true)
                        {
                            i = Convert.ToInt32(Console.ReadLine());
                            j = Convert.ToInt32(Console.ReadLine());
                            if (i < c + 1 && j < r + 1)
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("Введите новое значение: ");
                                        uint temp = Convert.ToUInt32(Console.ReadLine());
                                        if (temp != 0)
                                        {
                                            Console.WriteLine($" Была изменена {i} {j} ячейка таблицы c {matrxA[i - 1, j - 1]} на {temp}");
                                            matrxA[i - 1, j - 1] = temp;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы ввели нулевое значение! Повторите ввод");
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Введены некорректные данные!");
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введенная размерность не соответствует матрице! Повторите ввод");
                            }
                        }
                    }
                }

                Console.Clear();
                uint max = 0;//нахождение максимальной затраты на перевозку
                for (i = 0; i < matrxA.GetLength(0); i++)
                {
                    for (j = 0; j < matrxA.GetLength(1); j++)
                    {
                        if (matrxA[i, j] > max)
                        {
                            max = matrxA[i, j];
                        }
                    }
                }
                Console.WriteLine($"Максимальная затрата на перевозку равна - {max}");
                uint[,] matrxB = new uint[r, c];//новая таблица затрат, пересчитанная по правилу, указанному в задании
                for (i = 0; i < matrxB.GetLength(0); i++)
                {
                    for (j = 0; j < matrxB.GetLength(1); j++)
                    {
                        matrxB[i, j] = (max + 1) - matrxA[i, j];
                    }

                }
                Console.WriteLine("Пересчитанная таблица затрат:");//вывод на экран новой таблицы затрат
                for (i = 0; i < matrxB.GetLength(0); i++)
                {
                    for (j = 0; j < matrxB.GetLength(1); j++)
                    {
                        Console.Write(matrxB[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                uint[] m = new uint[r];//вектор мощности поставщиков
                uint[] n = new uint[c];//вектор спроса потребителей
                uint valueM = 0, valueN = 0;
                while (true)
                {
                    Console.WriteLine("Ввод данных о количестве продукции поставщиков (m):");//ввод данных в вектор мощности поставщиков
                    for (i = 0; i < m.Length; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write($"Введите количество продукции у {i + 1} поставщика: ");
                                m[i] = Convert.ToUInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Введены некорректные данные!");
                            }
                        }
                    }
                    Console.WriteLine("Ввод данных о запрашиваемом количестве продукции потребителями(n):");//ввод данных в вектор спроса потребителей
                    for (i = 0; i < n.Length; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write($"Введите количество необходимой продукции для {i + 1} потребителя: ");
                                n[i] = Convert.ToUInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Введены некорректные данные!");
                            }
                        }
                    }
                    for (i = 0; i < m.Length; i++)
                    {
                        valueM += m[i];
                    }
                    for (i = 0; i < n.Length; i++)
                    {
                        valueN += n[i];
                    }
                    if (valueM == valueN)
                    {
                        break;
                    }
                    else//проверка на равенство суммы элементов векторов
                    {
                        Console.WriteLine("Вектор мощности (m) и cпроса (n) должны быть равны, повторите ввод!");
                        valueM = 0;
                        valueN = 0;
                    }
                }
                Console.WriteLine("Вектор мощности (m):");//вывод на экран
                for (i = 0; i < m.Length; i++)
                {
                    Console.Write($"{m[i]} ");
                }
                Console.WriteLine("\nВектор спроса (n):");//вывод на экран
                for (i = 0; i < n.Length; i++)
                {
                    Console.Write($"{n[i]} ");
                }

                Console.WriteLine("\nМатрица тарифов:");//вывод на экран матрицы и векторов
                Console.Write("  ");
                for (i = 0; i < n.Length; i++)
                {
                    Console.Write($"{n[i]} ");
                }
                Console.WriteLine();
                for (i = 0; i < matrxB.GetLength(0); i++)
                {
                    Console.Write($"{m[i]} ");
                    for (j = 0; j < matrxB.GetLength(1); j++)
                    {
                        Console.Write($"{matrxB[i, j]} ");
                    }
                    Console.WriteLine();
                }
                uint[,] raspr = new uint[r, c];//массив для распределения
                for (i = 0; i < raspr.GetLength(0); i++)
                {
                    for (j = 0; j < raspr.GetLength(1); j++)
                    {
                        raspr[i, j] = 0;
                    }
                }
                i = 0;
                j = 0;
                //алгоритм распределения
                while (i < r && j < c)
                {
                    if (n[j] > m[i])
                    {
                        raspr[i, j] = m[i];
                        n[j] -= m[i];
                        m[i] = 0;
                        i++;
                    }
                    else
                    {
                        raspr[i, j] = n[j];
                        m[i] -= n[j];
                        n[j] = 0;
                        j++;
                    }
                }
                Console.WriteLine();
                for (i = 0; i < raspr.GetLength(0); i++)
                {
                    for (j = 0; j < raspr.GetLength(1); j++)
                    {
                        Console.Write($"{raspr[i, j]} ");
                    }
                    Console.WriteLine();
                }
                uint F = 0;//нахождение функции распределения
                for (i = 0; i < raspr.GetLength(0); i++)
                {
                    for (j = 0; j < raspr.GetLength(1); j++)
                    {
                        if (raspr[i, j] != 0)
                        {
                            F += raspr[i, j] * matrxB[i, j];
                        }
                    }
                }
                Console.WriteLine($"F = {F} у.д.е");
                while (true)
                {
                    try
                    {
                        Console.Write("\nПовторить программу?\nДа(Y)/Нет(N)\nОтвет: ");
                        otv = Convert.ToChar(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                if (!(otv.Equals('Y') || otv.Equals('y') || otv.Equals('н') || otv.Equals('Н')))
                {
                    break;
                }
                else if (!(otv.Equals('N') || otv.Equals('N') || otv.Equals('Т') || otv.Equals('т')))
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            }

        }
    }
}
 */










/*
// распределение с конченной формулой (максимальный элемент +1)-начальная матрица 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class 
    {
        struct 
        {

            public int Delivery { get; set; }
            public int Value { get; set; }
            public static int FindMinElement(int a, int b)
            {
                if (a > b) return b;
                if (a == b) { return a; }
                else return a;
            }

        }

        static void Main(string[] args)
        {
            bool o = true;
            string s;

            while (o == true)
            {
                try
                {
                    int i = 0;
                    int j = 0;
                    int x = 0;
                    int y = 0;
                    int n;
                    int max = 0;
                    int summa1 = 0;
                    int summa2 = 0;
                    bool check = true;
                    Console.WriteLine("Первоначальное распределение по методу северо-западного угла \n" +
                            " в транспортной задаче с учетом преобразования исходной матрицы \n" +
                            " А в матрицу В по правилу: B = {max(эл) + 1} - А \n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Введите количество поставщиков");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] a = new int[n];
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Введите количество потребителей");
                    int m = Convert.ToInt32(Console.ReadLine());
                    int[] b = new int[m];
                    Element[,] C = new Element[n, m];
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine();
                    while (check == true)
                    {
                        summa1 = 0;
                        summa2 = 0;
                        Console.WriteLine("Введите численные параметры поставщиков");
                        for (i = 0; i < a.Length; i++)
                        {
                            x = i + 1;
                            Console.Write($"Поставщик {x}: ");
                            a[i] = Convert.ToInt32(Console.ReadLine());
                            summa1 += a[i];
                        }
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine();
                        Console.WriteLine("Введите численные параметры потребителей");
                        for (j = 0; j < b.Length; j++)
                        {
                            y = j + 1;
                            Console.Write($"Потребитель {y}: ");
                            b[j] = Convert.ToInt32(Console.ReadLine());
                            summa2 += b[j];
                        }
                        if (summa1 == summa2)
                        {
                            check = false;
                        }
                        else if (summa1 != summa2)
                        {
                            check = true;
                        }
                        Console.Clear();
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Введите элементы матриц: ");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < m; j++)
                        {
                            Console.Write("a[{0},{1}] = ", i, j);
                            Console.ForegroundColor = ConsoleColor.Red;
                            C[i, j].Value = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();

                        }
                    }
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < m; j++)
                        {
                            if (max <= C[i, j].Value)
                            {
                                max = C[i, j].Value;
                            }
                        }
                    }
                    max += 1;
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < m; j++)
                        {
                            if (C[i, j].Value != 0)
                            {
                                C[i, j].Value = max - C[i, j].Value;
                            }
                        }
                    }
                    i = j = 0;
                    // действуем по алгоритму 

                    // идём с северо-западного элемента 
                    // если a[i] = 0 i++
                    // если b[j] = 0 j++
                    //  если a[i],b[j] = 0 то i++,j++;
                    // доходим до последнего i , j
                    while (i < n && j < m)
                    {
                        try
                        {
                            if (a[i] == 0) { i++; }
                            if (b[j] == 0) { j++; }
                            if (a[i] == 0 && b[j] == 0) { i++; j++; }
                            C[i, j].Delivery = Element.FindMinElement(a[i], b[j]);
                            a[i] -= C[i, j].Delivery;
                            b[j] -= C[i, j].Delivery;
                        }
                        catch { }
                    }
                    Console.WriteLine("\n Итоговая матрица: \n");
                    //выводим массив на экран
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < m; j++)
                        {
                            if (C[i, j].Delivery != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write("{0}", C[i, j].Value);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("({0})", C[i, j].Delivery); Console.ResetColor();
                            }
                            else
                                Console.Write("{0}({1})", C[i, j].Value, C[i, j].Delivery);
                        }
                        Console.WriteLine();
                    }
                    int ResultFunction = 0;
                    //считаем целевую функцию
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < m; j++) { ResultFunction += (C[i, j].Value * C[i, j].Delivery); }
                    }

                    Console.WriteLine(" F = {0}", ResultFunction);
                    i = 0;
                    j = 0;
                    int[] u = new int[n];
                    int[] v = new int[m];
                    Console.WriteLine("Хотите продолжать работу?(да/нет)");
                    s = Convert.ToString(Console.ReadLine());
                    if (s == "да")
                    {
                        o = true;
                        Console.Clear();
                    }
                    else if (s == "нет")
                    {
                        o = false;
                        Environment.Exit(0);
                    }
                    else { Environment.Exit(0); }
                }
                catch(Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Ошибка!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
 */










/*
// распределение минимальный
namespace Метод_потенциалов
{
    internal class 
    {
        static int[,] matr;
        static int[] mConst;
        static int[] nConst;

        /// <summary>
        /// Определение вырожденности
        /// </summary>
        /// <param name="divisionArray">Распределение</param>
        /// <param name="m">Поставщики</param>
        /// <param name="n">Потребители</param>
        static void degenerate(bool[,] divisionArray, int m, int n)
        {
            int kol = 0;
            foreach (bool  in divisionArray)
            {
                if (item)
                {
                    kol++;
                }
            }
            if (m + n - 1 != kol)
            {
                int min = 16;
                int iMin = 0;
                int jMin = 0;
                for (int i = 0; i < mConst.Length; i++)
                {
                    for (int j = 0; j < nConst.Length; j++)
                    {
                        if (!divisionArray[i, j])
                        {
                            if (matr[i, j] < min) //if (matr[i, j] <= min)
                                {
                                min = matr[i, j];
                                iMin = i;
                                jMin = j;
                            }
                        }
                    }
                }
                divisionArray[iMin, jMin] = true;
            }
        }

        /// <summary>
        /// Определение ячеек для цикла перераспределения
        /// </summary>
        /// <param name="divisionArrayBool">Информация о распределении</param>
        /// <param name="iMax">Индекс i максимальной дельты</param>
        /// <param name="jMax">Индекс j максимальной дельты</param>
        /// <returns>Строковый массив с индексами ячеек для цикла перераспределения</returns>
        static string[] cycle(bool[,] divisionArrayBool, int iMax, int jMax)
        {
            Console.WriteLine("Введите индексы ячеек, через которые будет проходить цикл, без разделителей.\nНапример: 13 - ячейка [1;3].");
            Console.WriteLine("Цикл можно проводить только через ячейки, в которых находятся единицы.");
            Console.WriteLine("Для завершения ввода введите 0.");
            Console.WriteLine("Цикл начинается из ячейки [{0},{1}]. Введите следующие ячейки.", iMax + 1, jMax + 1);
            string[] array = new string[1];
            array[0] = Convert.ToString(iMax) + Convert.ToString(jMax);
            int i = 1;
            string check = "0";
            while (true)
            {
                while (true)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("Введите ячейку цикла (+х): ");
                    }
                    else
                    {
                        Console.Write("Введите ячейку цикла (-х): ");
                    }

                    check = Console.ReadLine();
                    if (int.TryParse(check, out int result) && result > 10 && result < 35 || check == "0")
                    {
                        if (check == "0")
                        {
                            Console.Clear();
                            return ;
                        }
                        if (divisionArrayBool[Convert.ToInt32(check.Substring(0, 1)) - , Convert.ToInt32(check.Substring(1, 1)) - ])
                        {
                            Array.Resize(ref array, array.Length + 1);
                            array[i] = check;
                            i++;
                            break;
                        }
                    }
                    Console.WriteLine("Ошибка. Введите ячейку корректно!");
                }
            }
        }

        /// <summary>
        /// Расчёт потенциалов, дельты и цикла перераспределения (2, 3, 4 шаги)
        /// </summary>
        /// <param name="divisionArray">Распределение</param>
        /// <param name="divisionArrayBool">Информация о распределении (есть ли связь между поставщиком и потребителем)</param>
        /// <returns>Оптимальное распределение (true) или нет (false)</returns>
        static bool potentials(int[,] divisionArray, [,] )
        {
            int[] v = new int[mConst.Length];
            int[] u = new int[nConst.Length];
            bool[] vbool = new bool[mConst.Length];
            bool[] ubool = new bool[nConst.Length];
            ubool[0] = true;

            for (int i = 0; i < mConst.Length; i++)
            {
                if (divisionArrayBool[i, 0])
                {
                    v[i] = matr[i, 0];
                    vbool[i] = true;
                }
            }

            bool checkV = true;
            bool checkU = true;
            while (checkV || checkU)
            {
                for (int i = 0; i < mConst.Length; i++)
                {
                    for (int j = 1; j < nConst.Length; j++)
                    {
                        if (divisionArrayBool[i, j])
                        {
                            if (ubool[j])
                            {
                                v[i] = matr[i, j] - u[j];
                                vbool[i] = true;
                            }

                            if (vbool[i])
                            {
                                u[j] = matr[i, j] - v[i];
                                ubool[j] = true;
                            }
                        }
                    }
                }

                checkU = false;
                foreach (bool item in ubool)
                {
                    if (item == false)
                    {
                        checkU = true;
                        break;
                    }
                }
                checkV = false;
                foreach (bool item in vbool)
                {
                    if (item == false)
                    {
                        checkV = true;
                        break;
                    }
                }
            }

            int[,] delta = new int[mConst.Length, nConst.Length];
            for (int i = 0; i < mConst.Length; i++)
            {
                for (int j = 0; j < nConst.Length; j++)
                {
                    if (!divisionArrayBool[i, j])
                    {
                        delta[i, j] = v[i] + u[j] - matr[i, j];
                    }
                }
            }

            bool check = false;
            foreach (int item in delta)
            {
                if (item > 0)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                return true;
            }

            int max = delta[0, 0];
            int iMax = 0;
            int jMax = 0;
            for (int i = 0; i < mConst.Length; i++)
            {
                for (int j = 0; j < nConst.Length; j++)
                {
                    if (delta[i, j] > max)
                    {
                        max = delta[i, j];
                        iMax = i;
                        jMax = j;
                    }
                }
            }

            for (int i = 0; i < mConst.Length; i++)
            {
                for (int j = 0; j < nConst.Length; j++)
                {
                    if (divisionArrayBool[i, j])
                    {
                        Console.Write(1 + "\t");
                    }
                    else
                    {
                        Console.Write(0 + "\t");
                    }
                }
                Console.WriteLine();
            }

            string[] cycleArray = cycle(divisionArrayBool, iMax, jMax);

            int iMin = Convert.ToInt32(cycleArray[1].Substring(0, 1)) - 1;
            int jMin = Convert.ToInt32(cycleArray[1].Substring(1, 1)) - 1;
            int min = divisionArray[iMin, jMin];
            for (int i = 3; i < cycleArray.Length; i+=2)
            {
                iMin = Convert.ToInt32(cycleArray[i].Substring(0, 1)) - 1;
                jMin = Convert.ToInt32(cycleArray[i].Substring(1, 1)) - 1;
                if (divisionArray[iMin, jMin] < min)
                {
                    min = divisionArray[iMin, jMin];
                }
            }

            int indexI = Convert.ToInt32(cycleArray[0].Substring(0, 1));
            int jndexJ = Convert.ToInt32(cycleArray[0].Substring(1, 1));
            divisionArray[indexI, jndexJ] += min;
            if (divisionArray[indexI, jndexJ] > 0)
            {
                divisionArrayBool[indexI, jndexJ] = true;
            }

            for (int c = 1; c < cycleArray.Length; c++)
            {
                int i = Convert.ToInt32(cycleArray[c].Substring(0, 1)) - 1;
                int j = Convert.ToInt32(cycleArray[c].Substring(1, 1)) - 1;
                if (c % 2 == 0)
                {
                    divisionArray[i, j] += min;
                    if (divisionArray[i, j] > 0)
                    {
                        divisionArrayBool[i, j] = true;
                    }
                }
                else
                {
                    divisionArray[i, j] -= min;
                    if (divisionArray[i, j] == 0)
                    {
                        divisionArrayBool[i, j] = false;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Расчёт функции и заключения договоров
        /// </summary>
        static void calculation()
        {
            int[] m = new int[mConst.Length];
            int[] n = new int[nConst.Length];
            bool[,] divisionArrayBool = new bool[m.Length, n.Length];
            int[,] divisionArray = new int[m.Length, n.Length];
            int[,] firstDivision = new int[m.Length, n.Length];
            bool check = false;
            int func = 0;
            string funcS = "";

            Array.Copy(matr, firstDivision, matr.Length);
            Array.Copy(mConst, m, mConst.Length);
            Array.Copy(nConst, n, nConst.Length);

            int sum = 1;

            while (sum != 0)
            {
                int min = 16;
                int iMin = 0;
                int jMin = 0;

                for (int i = 0; i < m.Length; i++)
                {
                    for (int j = 0; j < n.Length; j++)
                    {
                        if (firstDivision[i, j] < min && firstDivision[i, j] > 0)
                        {
                            min = firstDivision[i, j];
                            iMin = i;
                            jMin = j;
                        }
                    }
                }

                firstDivision[iMin, jMin] = 0;

                if (m[iMin] > 0 && n[jMin] > 0)
                {
                    if (n[jMin] < m[iMin])
                    {
                        func += matr[iMin, jMin] * n[jMin];
                        funcS += matr[iMin, jMin] + "*" + n[jMin] + " + ";
                        divisionArray[iMin, jMin] = n[jMin];
                        divisionArrayBool[iMin, jMin] = true;
                        m[iMin] -= n[jMin];
                        n[jMin] = 0;
                    }
                    else
                    {
                        func += matr[iMin, jMin] * m[iMin];
                        funcS += matr[iMin, jMin] + "*" + m[iMin] + " + ";
                        divisionArray[iMin, jMin] = m[iMin];
                        divisionArrayBool[iMin, jMin] = true;
                        n[jMin] -= m[iMin];
                        m[iMin] = 0;
                    }
                }

                sum = 0;
                foreach (int item in m)
                {
                    sum += item;
                }
            }

            degenerate(divisionArrayBool, m.Length, n.Length);

            funcS = "Ответ: Fопт = " + funcS.Substring(0, funcS.Length - 3) + " = " + func + " у.д.е.";

            check = potentials(divisionArray, divisionArrayBool);

            if (!check)
            {
                while (check != true)
                {
                    funcS = "";
                    func = 0;

                    Array.Copy(mConst, m, mConst.Length);
                    Array.Copy(nConst, n, nConst.Length);

                    for (int i = 0; i < m.Length; i++)
                    {
                        for (int j = 0; j < n.Length; j++)
                        {
                            if (divisionArray[i, j] > 0)
                            {
                                if (n[j] < m[i])
                                {
                                    func += matr[i, j] * divisionArray[i, j];
                                    funcS += matr[i, j] + "*" + divisionArray[i, j] + " + ";
                                }
                                else
                                {
                                    func += matr[i, j] * divisionArray[i, j];
                                    funcS += matr[i, j] + "*" + divisionArray[i, j] + " + ";
                                }
                            }
                        }
                    }

                    funcS = "Ответ: Fопт = " + funcS.Substring(0, funcS.Length - 3) + " = " + func + " у.д.е.";

                    check = potentials(divisionArray, divisionArrayBool);
                }
            }
            Console.WriteLine(funcS + "\n");

            Console.WriteLine("\t\tЗаключение договоров");
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (divisionArray[i, j] > 0)
                    {
                        Console.WriteLine("{0}-й поставщик с {1}-м потребителем на {2} ед. продукции", i + 1, j + 1, divisionArray[i, j]);
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Заполнение исходных данных по условию задачи
        /// </summary>
        static void fill()
        {
            matr = new int[3, 4];
            matr[0, 0] = 9;
            matr[0, 1] = 5;
            matr[0, 2] = 3;
            matr[0, 3] = 10;
            matr[1, 0] = 6;
            matr[1, 1] = 3;
            matr[1, 2] = 8;
            matr[1, 3] = 2;
            matr[2, 0] = 3;
            matr[2, 1] = 8;
            matr[2, 2] = 4;
            matr[2, 3] = 7;

            mConst = new int[3];
            mConst[0] = 25;
            mConst[1] = 55;
            mConst[2] = 22;

            nConst = new int[4];
            nConst[0] = 45;
            nConst[1] = 15;
            nConst[2] = 22;
            nConst[3] = 20;
        }

        /// <summary>
        /// Ввод исходных данных вручную
        /// </summary>
        static void vvod()
        {
            int m, n;
            while (true)
            {
                Console.Write("Введите количество поставщиков: ");
                if (int.TryParse(Console.ReadLine(), out int result) && result > 1 && result < 11)
                {
                    m = result;
                    break;
                }
                Console.WriteLine("Ошибка. Введите значение корректно!");
            }

            while (true)
            {
                Console.Write("Введите количество потребителей: ");
                if (int.TryParse(Console.ReadLine(), out int result) && result > 1 && result < 11)
                {
                    n = result;
                    break;
                }
                Console.WriteLine("Ошибка. Введите значение корректно!");
            }

            matr = new int[m, n];
            mConst = new int[m];
            nConst = new int[n];

            Console.WriteLine("Заполнение матрицы затрат на перевозку.");
            for (int i = 0; i < mConst.Length; i++)
            {
                for (int j = 0; j < nConst.Length; j++)
                {
                    while (true)
                    {
                        Console.Write("Введите [{0},{1}] элемент матрицы: ", i + 1, j + 1);
                        if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 16)
                        {
                            matr[i, j] = result;
                            break;
                        }
                        Console.WriteLine("Ошибка. Введите значение корректно!");
                    }
                }
            }
            while (true)
            {
                for (int i = 0; i < mConst.Length; i++)
                {
                    while (true)
                    {
                        Console.Write("Введите мощность {0}-го поставщика: ", i + 1);
                        if (int.TryParse(Console.ReadLine(), out int result) && result > 1 && result < 151)
                        {
                            mConst[i] = result;
                            break;
                        }
                        Console.WriteLine("Ошибка. Введите значение корректно!");
                    }
                }

                for (int i = 0; i < nConst.Length; i++)
                {
                    while (true)
                    {
                        Console.Write("Введите спрос {0}-го потребителя: ", i + 1);
                        if (int.TryParse(Console.ReadLine(), out int result) && result > 1 && result < 151)
                        {
                            nConst[i] = result;
                            break;
                        }
                        Console.WriteLine("Ошибка. Введите значение корректно!");
                    }
                }

                Console.Clear();

                int sumM = 0;
                foreach (int item in mConst)
                {
                    sumM += item;
                }
                int sumN = 0;
                foreach (int item in nConst)
                {
                    sumN += item;
                }

                if (sumM == sumN)
                {
                    break;
                }
                Console.WriteLine("Ошибка. Суммарные мощности поставщиков и спросов потребителей не равны!");
            }
        }

        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("1 - Ввести данные вручную.");
                Console.WriteLine("2 - Заполнить данные автоматически (по условию задачи).");
                Console.WriteLine("3 - Очистить экран.");
                Console.WriteLine("4 - Завершить работу.");
                Console.Write("Выберите действие: ");
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 5)
                {
                    switch (result)
                    {
                        case 1:
                            Console.Clear();
                            vvod();
                            calculation();
                            break;
                        case 2:
                            Console.Clear();
                            fill();
                            calculation();
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
                            check = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введите действие корректно!");
                }
            }
        }
    }
}
 */






/*
 //Методом потенциалов. (с преобразованием из лаб.6) Найти оптимальное распределение трех видов механизмов между тремя участками работ. Данные об эффективности использования механизмов конкретного типа на участке работ сведены в таблицу.    
 ﻿using System;


namespace matmodelirovanie
{
    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Задача №3.\nНахождение оптимального распределения трех видов механизмов между тремя участками работ. ");//постановка задачи
                uint r1, r2;//размерности матрицы и векторов
                r1 = 3;
                r2 = 3;
                char otv;//переменная для диалога
                uint[,] arr = new uint[r2, r1];//матрица затрат
                uint[] m = new uint[r2];//вектор мощности
                uint[] n = new uint[r1];//вектор спроса
                uint valueM = 0, valueN = 0;//переменные для подсчета суммы
                uint min = uint.MaxValue;//переменная для поиска минимального элемента
                uint max = uint.MinValue;//переменная для поиска максимального элемента
                uint minL = uint.MinValue;
                uint maxx = uint.MinValue;//переменная для поиска максимального элемента
                int indI = 0, indJ = 0;//переменные для хранения индекса минимального элемента
                int indII = 0, indJJ = 0;//переменные для хранения индекса максимального элемента
                uint[,] raspr = new uint[r2, r1];//массив в котором хранятся значения, куда и сколько использовалось механизмов
                uint F = 0;//целевая функция
                string[] postavki = new string[0];//массив строк в котором прописано, кто с кем заключил договор
                string[,] itog = new string[r2, r1];//матрица, которая схожа с исходной, но в ней проставлены поставки через слеш
                Console.WriteLine();
                Console.WriteLine("Ввод данных об эффективности использования механизмов конкретного типа на участках работы:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        while (true) // ввод данных об эффективности использования механизмов конкретного типа на участках работы
                        {
                            try
                            {
                                Console.Write($"Введите производительность {i + 1}-го механизма при работе на {j + 1}-ом участке: ");
                                arr[i, j] = Convert.ToUInt32(Console.ReadLine());
                                if (arr[i, j] > 0)
                                    break;
                                else
                                {
                                    Console.WriteLine($"Не можеть быть 0");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Введены некорректные данные!");
                            }
                        }
                    }
                }
                while (true) // ввод данных об количестве механизмов каждого типа
                {
                    Console.WriteLine();
                    Console.WriteLine("Ввод данных о количестве механизмов каждого типа:");
                    for (int i = 0; i < m.Length; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write($"Введите количество механизмов {i + 1}-го типа: ");
                                m[i] = Convert.ToUInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Введены некорректные данные!");
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ввод данных о запрашиваемых механизмах для каждого участка:");
                    for (int i = 0; i < n.Length; i++)
                    {

                        while (true) //ввод данных о запрашиваемых механизмах для каждого участка
                        {
                            try
                            {
                                Console.Write($"Введите количество запрашиваемых механизмов для {i + 1}-го участка работы: ");
                                n[i] = Convert.ToUInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Введены некорректные данные!");
                            }
                        }
                    }
                    for (int i = 0; i < m.Length; i++) // проверка на одинаковость суммы векторов
                    {
                        valueM += m[i];
                    }
                    for (int i = 0; i < n.Length; i++)
                    {
                        valueN += n[i];
                    }
                    if (valueM == valueN)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вектор механизмов и участков работ должны быть равны, повторите ввод!");
                        valueM = 0;
                        valueN = 0;
                    }
                }
                Console.WriteLine();
                //вывод таблицы производительности и векторов
                Console.WriteLine("\nТаблица производительности:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Вектор механизмов (m):");
                for (int i = 0; i < m.Length; i++)
                {
                    Console.Write($"{m[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine("\nВектор участков работы (n):");
                for (int i = 0; i < n.Length; i++)
                {
                    Console.Write($"{n[i]} ");
                }
                //Возможность изменять матрицу
                while (true)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("\nХотите изменить данные в таблице?\nЕсли нет, то нажмите на кнопку Д на клавиатуре\nЕсли да, то можете нажать на любую другую кнопку\nОтвет: ");
                            otv = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Введены некорректные данные!");
                        }
                    }
                    if (otv.Equals('l') || otv.Equals('д') || otv.Equals('Д') || otv.Equals('L'))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Введите номер вида механизма, затем номер участка работ, который вы хотите изменить\nОтвет:\n");
                        while (true)
                        {
                            int i = Convert.ToInt32(Console.ReadLine()), j = Convert.ToInt32(Console.ReadLine());
                            if (i < r2 + 1 && j < r1 + 1)
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("Введите новое значение: ");
                                        uint temp = Convert.ToUInt32(Console.ReadLine());
                                        if (temp != 0)
                                        {
                                            Console.WriteLine($"Вы изменили {i} {j} ячейку таблицы c {arr[i - 1, j - 1]} на {temp}");
                                            arr[i - 1, j - 1] = temp;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Нельзя ввести нулевое значение! Повторите ввод");
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Введены некорректные данные!");
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Введенная размерность не соответствует! Повторите ввод");
                            }
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("\nМатрица:"); //вывод матрицы тарифов
                Console.Write(" ");
                for (int i = 0; i < n.Length; i++)
                {
                    Console.Write($"{n[i]} ");
                }
                Console.WriteLine();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.Write($"{m[i]} ");
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < raspr.GetLength(0); i++) // создание таблицы распределения и заполнение её пока что нулями
                {
                    for (int j = 0; j < raspr.GetLength(1); j++)
                    {
                        raspr[i, j] = 0;
                    }
                }
                max = uint.MinValue; // Максимальное значение
                for (int i = 0; i < arr.GetLength(0); i++) // поиск максимального и преобразование по формуле Maxl+1-A
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                        }
                    }
                }
                max = max + 1;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = max - arr[i, j]; // преобразование по формуле Maxl+1-A
                    }
                }
                Console.WriteLine("\nПреобразование значений матрицы:"); // вывод преобразованной таблицы
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($" {arr[i, j]} ");
                    }
                    Console.WriteLine();
                }
                while (true) //алгоритм решения по минимальному элементу
                {
                    min = uint.MaxValue;
                    valueM = 0;
                    valueN = 0;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] < min && raspr[i, j] == 0 && m[i] != 0 && n[j] != 0)
                            {
                                min = arr[i, j];
                                indI = i;
                                indJ = j;
                            }
                        }
                    }
                    if (n[indJ] != 0 && m[indI] != 0)
                    {
                        if (n[indJ] > m[indI])
                        {
                            raspr[indI, indJ] = m[indI];
                            n[indJ] -= m[indI];
                            m[indI] = 0;
                        }
                        else
                        {
                            raspr[indI, indJ] = n[indJ];
                            m[indI] -= n[indJ];
                            n[indJ] = 0;
                        }
                    }
                    for (int i = 0; i < m.Length; i++) // проверка на то, что первоначальное рапределение выполнено полностью
                    {
                        valueM += m[i];
                    }
                    for (int i = 0; i < n.Length; i++)
                    {
                        valueN += n[i];
                    }
                    if (valueM == 0 && valueN == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("\nПервоначальное распределение методом минимального элемента:");
                uint zap = 0;//переменная для подсчета заполненных клеток, понадобиться для проверки вырожденности
                for (int i = 0; i < itog.GetLength(0); i++) //вывод матрицы, в которой через слеш написаны поставки
                {
                    for (int j = 0; j < itog.GetLength(1); j++)
                    {
                        if (raspr[i, j] != 0)
                        {
                            itog[i, j] = $"{arr[i, j]}/{raspr[i, j]}";
                            zap = zap + 1;
                        }
                        else
                        {
                            itog[i, j] = $"{arr[i, j]} ";
                        }
                        Console.Write($"{itog[i, j]} ");
                    }
                    Console.WriteLine();
                }
                uint strst = r1 + r2 - 1;
                minL = uint.MaxValue; //проверка на вырожденность
                Console.WriteLine();
                Console.WriteLine("\nПроверка на вырожденность:");
                if (strst != zap) //если количество заполненных клеток не равно столбцы+строки-1, то приписание 0 в мин поставку из свободных
                {
                    Console.WriteLine("Таблица вырождена");
                    for (int i =
                    0; i < arr.GetLength(0); i++) // поиск миним. эл среди не заполненных
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (raspr[i, j] == 0)
                            {
                                if (arr[i, j] < minL)
                                {
                                    minL = arr[i, j];
                                    indI = i;
                                    indJ = j;
                                }
                            }
                        }
                    }
                    raspr[indI, indJ] = 9999; // помечаем не заполненные минимальные клетки
                    for (int i = 0; i < itog.GetLength(0); i++)
                    {
                        for (int j = 0; j < itog.GetLength(1); j++)
                        {
                            if (raspr[i, j] != 0 && raspr[i, j] != 9999)
                            {
                                itog[i, j] = $"{arr[i, j]}/{raspr[i, j]}";

                            }
                            else if (raspr[i, j] == 9999)
                            {
                                itog[i, j] = $"{arr[i, j]}/{raspr[i, j] - 9999}"; //добавление поставки 0
                            }
                            else
                            {
                                itog[i, j] = $"{arr[i, j]} ";
                            }
                            Console.Write($"{itog[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Таблица не вырождена");
                }
            metka:

                Console.WriteLine();
                int[] U = new int[r2]; // начальное заполнение массива потенциалов, для дальнейшего решения
                int[] V = new int[r1];
                for (int i = 0; i < r1; i++)
                {
                    U[i] = 99;
                    V[i] = 99;
                }
                //Для заполненных клеток рассчитываются потенциалы Uj и Vi
                // проверка на то, является ли ячейка пустой и не записаны ли для неё потенциалы, если нет, то высчитывается потенциал
                Console.WriteLine("Расчёт потенциалов");
                while (true)
                {
                    bool proverk = true; // для выхода из бесконечного цикла
                    U[0] = 0; // первому элементу u всегда присваивается 0
                    for (int j = 0; j < r2; j++)
                    {
                        for (int i = 0; i < r1; i++)
                        {
                            if (raspr[i, j] != 0)
                            {
                                if (U[j] != 99)
                                {
                                    V[i] = Convert.ToInt32(arr[i, j] - U[j]); // растановка потенциалов V
                                }
                                else if (V[i] != 99)
                                {
                                    U[j] = Convert.ToInt32(arr[i, j] - V[i]);// растановка потенциалов U
                                }
                            }
                        }
                    }
                    for (int i = 0; i < r1; i++) // если все потенциалы расставлены, т.е они перестали быть = 99, то выходим из бессконечного цикла
                    {
                        if (U[i] == 99 || V[i] == 99)
                        {
                            proverk = false;
                        }
                    }
                    if (proverk)
                    {
                        break;
                    }
                }
                Console.WriteLine("Таблица с раставленными потенциалами:"); // вывод таблицы с потенциалами
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{itog[i, j]} ");
                    }
                    Console.Write($" {V[i]}");
                    Console.WriteLine();
                }
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    Console.Write($"{U[i]} ");
                }
                Console.WriteLine();
                Console.WriteLine();
                int[,] Delta = new int[r2, r1]; // задаеем массив дельт
                int maxxx = 0; // задаем максимпальной дельте 0
                Console.WriteLine("Для пустых клеток расчет дельты:");
                for (int i = 0; i < arr.GetLength(0); i++) //определение оптимальности - расчет дельта
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (raspr[i, j] == 0) // если клетка пустая, то считаем дельту
                        {
                            Delta[i, j] = Convert.ToInt32(U[j] + V[i] - arr[i, j]);
                            if (Delta[i, j] > maxxx) // если посчитанная дельта больше макс.дельты, то присваиваем максимальной дельте полученную дельту и запоминаем её индексы
                            {
                                maxxx = Delta[i, j];
                                indI = i;
                                indJ = j;
                            }
                            if (Delta[i, j] == maxxx && Delta[i, j] != 0) // выводим положительные дельты
                            {
                                Console.WriteLine($"{i + 1}{j + 1} = {Delta[i, j]} - max");
                            }
                            else // выводим не положительные дельты
                            {
                                Console.WriteLine($"{i + 1}{j + 1} = {Delta[i, j]}");
                            }
                        }
                    }
                }
                Console.WriteLine();
                int[,] optimal = new int[r2, r1]; // массив оптимальности, для построения цикла перераспределения
                int indi = indI; // переприсвоение индексов максимальной дельты
                int indj = indJ;
                bool proverk1 = true; // для выхода из бесконечного цикла
                bool proverk2 = true;
                if (maxxx > 0) // проверка на оптимальность
                {
                    Console.WriteLine("Решение не оптимальное:");
                    for (int i = 0; i < optimal.GetLength(0); i++)
                    {
                        for (int j = 0; j < optimal.GetLength(0); j++)
                        {
                            optimal[i, j] = 0; // заполнение массива 0, понадобится для дальнейших расчетов
                            if (i == indI && j == indJ) //если элемент является максимальрной дельтой, то присваиваем ему 1 (отличный от всех)
                            {
                                optimal[i, j] = 1;
                            }
                        }
                    }

                    F = 0; // промежуточный вывод целувой функции
                    for (int i = 0; i < raspr.GetLength(0); i++)
                    {
                        for (int
                        j = 0; j < raspr.GetLength(1); j++)
                        {
                            if (raspr[i, j] != 0 && raspr[i, j] != 9999)
                            {
                                F += raspr[i, j] * arr[i, j];
                            }
                        }
                    }
                    Console.WriteLine($"\nF = {F} у.д.е");
                    Console.WriteLine();
                    while (true)
                    {
                        proverk2 = true; //для бесконечного цикла
                        for (int i = 0; i < optimal.GetLength(0); i++)
                        {
                            for (int j = 0; j < optimal.GetLength(1); j++)
                            {
                                if (i != indi && j != indj && raspr[i, j] != 0 && optimal[i, j] != 2) // находим заполненные клетки, которые не являются максимальной дельтой
                                {
                                    optimal[i, j] = 2; // присваиваем им 2, для отличия
                                    indI = i;
                                    indJ = j;
                                    proverk2 = false; // выход из бесконечного цикла по j
                                    break;
                                }
                            }
                            if (!proverk2) // выход из бесконечного цикла по i
                            {
                                break;
                            }
                        }
                        if (raspr[indI, indj] != 0 && raspr[indi, indJ] != 0) // строим цикл перераспр.
                        {
                            optimal[indI, indj] = optimal[indi, indJ] = -1; //помечаем клетку от куда будем вычитать -x
                            optimal[indI, indJ] = 1;//помечаем клетку куда будем прибавлять +x
                            proverk1 = false;
                        }
                        if (!proverk1) // выход из бесконечного цикла
                        {
                            break;
                        }
                    }
                    uint minT = uint.MaxValue;
                    for (int i = 0; i < optimal.GetLength(0); i++) // выбираем X=MIN(-x)
                    {
                        for (int j = 0; j < optimal.GetLength(1); j++)
                        {
                            if (optimal[i, j] == -1)
                            {
                                if (raspr[i, j] < minT)
                                {
                                    minT = raspr[i, j];
                                }
                            }
                        }
                    }
                    Console.WriteLine($"X = MIN = {minT}");
                    Console.WriteLine();
                    for (int i = 0; i < optimal.GetLength(0); i++) // выполняем перераспределение
                    {
                        for (int j = 0; j < optimal.GetLength(1); j++)
                        {
                            if (optimal[i, j] == -1) // если клетка помечена -1, из её поставки вычитаем MIN
                            {
                                raspr[i, j] -= Convert.ToUInt32(minT);
                            }
                            if (optimal[i, j] == 1 && raspr[i, j] != 9999) // если клетка помечена 1 и является заполненной к ней прибавляем MIN
                            {
                                raspr[i, j] += Convert.ToUInt32(minT);
                            }
                            else if (optimal[i, j] == 1 && raspr[i, j] == 999) //если клетка помечена 1 и не заполнена к ней прибавляем MIN
                            {
                                raspr[i, j] += Convert.ToUInt32(minT) - 999;
                            }
                        }
                    }
                    zap = 0; // вывод матрицы после цикла перераспределения
                    Console.WriteLine("Построенные цикл перераспределения");
                    for (int i = 0; i < itog.GetLength(0); i++)
                    {
                        for (int j = 0; j < itog.GetLength(1); j++)
                        {
                            if (raspr[i, j] != 0 && raspr[i, j] != 9999)
                            {
                                itog[i, j] = $"{arr[i, j]}/{raspr[i, j]} ";
                                zap++;
                            }
                            else if (raspr[i, j] == 9999)
                            {
                                itog[i, j] = $"{arr[i, j]}/{raspr[i, j] - 9999} ";
                                zap++;
                            }
                            else
                            {
                                itog[i, j] = $"{arr[i, j]} ";
                            }
                            Console.Write($"{itog[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    goto metka; // опять проверка на оптимальность
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Решение оптимальное:");
                    max = uint.MinValue; // Максимальное значение
                    for (int i = 0; i < arr.GetLength(0); i++) // поиск максимального и преобразование по формуле Maxl+1-A
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] > max)
                            {
                                max = arr[i, j];
                            }
                        }
                    }
                    max = max + 1;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            arr[i, j] = max - arr[i, j]; // преобразование по формуле Maxl+1-A
                        }
                    }
                    Console.WriteLine("\nОбратное преобразование матрицы:"); // вывод преобразованной таблицы
                    for (int i = 0; i < itog.GetLength(0); i++)
                    {
                        for (int j = 0; j < itog.GetLength(1); j++)
                        {
                            if (raspr[i, j] != 0 && raspr[i, j] != 9999)
                            {
                                itog[i, j] = $"{arr[i, j]}/{raspr[i, j]}";
                                zap++;
                            }
                            else if (raspr[i, j] == 9999)
                            {
                                itog[i, j] = $"{arr[i, j]}/{raspr[i, j] - 9999}";
                                zap++;
                            }
                            else
                            {
                                itog[i, j] = $"{arr[i, j]} ";
                            }
                            Console.Write($"{itog[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    F = 0;//подсчет и вывод целевой функции
                    for (int i = 0; i < raspr.GetLength(0); i++)
                    {
                        for (int j = 0; j < raspr.GetLength(1); j++)
                        {
                            if (raspr[i, j] != 0 && raspr[i, j] != 9999)
                            {
                                F += raspr[i, j] * arr[i, j];
                            }
                        }
                    }
                    Console.WriteLine($"\nF = {F} у.д.е");
                }
                // повтор выполнения программы
                while (true)
                {
                    try
                    {
                        Console.Write("\nХотите повторить выполнение программы?\nЕсли да, то нажмите на кнопку Y(на англ) на клавиатуре\nЕсли нет, то можете нажать на любую другую кнопку\nОтвет: ");
                        otv = Convert.ToChar(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введены некорректные данные!");
                    }
                }
                if (!(otv.Equals('Y') || otv.Equals('y') || otv.Equals('н') || otv.Equals('Н')))
                {
                    Console.WriteLine("Программу выполнила студентка группы 31П\nЛебедева Александра Федоровна");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
 */





// ЗАДАЧА 33П!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
/*
 // ГЛАВНЫЙ МЕТОД

 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace МЭ_вар2
{
    public class Program
    {
        public static List<User_income> user_income = new List<User_income>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальную сумму");
            User user = new User(Convert.ToInt32(Console.ReadLine()));
            User_contribution contribution = new User_contribution(user.money);

            for (int i = 1; i <= user.month; i++)
            {
                contribution.all_money += contribution.Get_persentMoney();
                if (i == user.month)
                {
                    Console.WriteLine($"Итого");
                    Console.WriteLine($"{contribution.all_money}  % - {contribution.percent}");
                }
                else
                {
                    Console.WriteLine($"Месяц {i}");
                    Console.WriteLine($"{contribution.all_money}  % - {contribution.percent}");
                    Console.WriteLine("_________________________________");
                }

                if (i % 3 == 0)
                {
                    contribution.Update_percent();
                }
            }
            Console.WriteLine("Расчитать максимальный максимальный доход при вложении до 1.000.000?");
        sw:
            switch (Console.ReadLine().ToLower())
            {
                case "да":
                    Console.Clear();
                    Get_maxIncome();
                    break;
                case "нет":
                    Console.Clear();
                    break;
                default:
                    Console.MoveBufferArea(0, 38, Console.BufferWidth, 1, Console.BufferWidth, 38, ' ', Console.ForegroundColor, Console.BackgroundColor);
                    Console.SetCursorPosition(0, 38);

                    goto sw;
                    break;
            }

            Console.ReadKey();
        }

        public static void Get_maxIncome()
        {
  
            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("../../../Output.txt"));

            Debug.Listeners.Add(tr2);
            for (int i = 50000; i <= 1000000; i += 1000)
            {
                User user = new User(i);
                User_contribution contribution = new User_contribution(user.money);

                for (int m = 1; m <= user.month; m++)
                {
                    contribution.all_money += contribution.Get_persentMoney();
                    if (i % 3 == 0)
                    {
                        contribution.Update_percent();
                    }
                }
                user_income.Add(new User_income(user.money, contribution.all_money));
            }

            var income = user_income.OrderByDescending(u => u.end_money);
            Console.WriteLine($"\nмаксимальный доход -------- начальная сумма - {income.First().start_money}, конечная сумма - {income.First().end_money}");
            Debug.WriteLine($"\nмаксимальный доход -------- начальная сумма - {income.First().start_money}, конечная сумма - {income.First().end_money}");
            Debug.Flush();
        }
    }
}


//КЛАСС 1 User
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МЭ_вар2
{
    public class User
    {
        public int money{ get; set; }
        public int month { get; set; } = 12;

        public User(int money) 
        { 
            this.money = money;
        }

    }
}

//КЛАСС 2 User_contribution
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МЭ_вар2
{
    public class User_contribution
    {
        public double all_money { get; set; }
        public double percent_money { get; set; }
        public int tax{ get; set; } = 0;
        public double percent { get; set; }

        private double percent_bank = 8.0;

        public User_contribution(int all_money)
        {
            this.all_money = all_money;

            if(all_money < 700000)
            {
                percent = all_money / 50000 + 1;
            }
            else
            {
                int s = all_money - 700000;
                percent = 20 - s / 50000;
            }
            if(percent > percent_bank + 5)
            {
                tax = 30;
            }
        }

        public double Get_persentMoney()
        {
            double m = Math.Round(percent * all_money / 100,2);
            return m - Math.Round(tax * m / 100,2);
        }

        public void Update_percent()
        {
            percent += 0.5;
            if (percent > percent_bank + 5)
            {
                tax = 30;
            }
        }
    }
}

// КЛАСС 3 User_income
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МЭ_вар2
{
    public class User_income
    {
        public double start_money { get; set; }
        public double end_money { get; set; }

        public User_income(double start_money, double end_money)
        {
            this.start_money = start_money;
            this.end_money = end_money;
        }
    }
}


// ТЕСТЫ
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using МЭ_вар2;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetPercentMoney()
        {
            var cont = new User_contribution(750000);

            double result = cont.Get_persentMoney();
            double expected = 99750;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTax()
        {
            var cont = new User_contribution(750000);
            int result = cont.tax;
            int expected = 30;

            Assert.AreEqual(expected, result);
        }
    }
}


 */