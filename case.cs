//завдання: case 19
//варіант 29

Console.OutputEncoding = System.Text.Encoding.Default; // усунення проблем відображання української мови

Console.WriteLine("Введіть дату: ");
int D = Convert.ToInt32(Console.ReadLine()); // користувач вводить дату
Console.WriteLine("Введіть місяць: ");
int M = Convert.ToInt32(Console.ReadLine()); // користувач вводить місяць

switch (M)
{

    case 1: // перший кейс, який перевіряє дату на правильність
        {

            if (D == 31) // дія, якщо дата дорівнює 31
            {
                Console.Write("Дата: ");
                Console.WriteLine(D = 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M = M + 1);
                break;
            }
            else if (D > 31) // дія, якщо введена дата не правильна
            {
                Console.WriteLine("Такої дати не існує!");
                break;
            }
            else // дія в інших випадках
            {
                Console.Write("Дата: ");
                Console.WriteLine(D + 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M);
                break;
            }
        }
    case 2: // перший кейс, який перевіряє дату на правильність
        {
            if (D == 28) // перша дія перевіряє чи рівна дата 28
            {
                Console.Write("Дата: ");
                Console.WriteLine(D = 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M = M + 1);
                break;
            }
            else if (D > 28) // якщо дата більше 28, виконується друга дія
            {
                Console.WriteLine("Такої дати не існує!");
                break;
            }
            else // в інших випадках
            {
                Console.Write("Дата: ");
                Console.WriteLine(D + 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M);
                break;
            }
        }

    case 3:
        {
            if (D == 30) // перша дія перевіряє чи рівна дата 30
            {
                Console.Write("Дата: ");
                Console.WriteLine(D = 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M = M + 1);
                break;
            }
            else if (D > 30) // друга дія перевіряє чи дата не більше 30
            {
                Console.WriteLine("Такої дати не існує!");
                break;
            }
            else // в інших випадках
            {
                Console.Write("Дата: ");
                Console.WriteLine(D + 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M);
                break;
            }
        }
    case 4:
        {
            if (D == 31) // перша дія перевіряє чи рівна дата 31
            {
                Console.Write("Дата: ");
                Console.WriteLine(D = 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M = 1);
                break;
            }
            else if (D > 31) // друга дія перевіряє чи дата не більше 31
            {
                Console.WriteLine("Такої дати не існує!");
                break;
            }
            else // в інших випадках
            {
                Console.Write("Дата: ");
                Console.WriteLine(D + 1);
                Console.Write("Місяць: ");
                Console.WriteLine(M);
                break;
            }
        }
}
