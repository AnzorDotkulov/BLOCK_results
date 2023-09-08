// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам


Console.Write("Напишите как вы хотите заполнить массив:\na - с клавиатуры. h - готовый список.\n");
string answer = Console.ReadLine();
string[] array = new string[5] {"Hello", "2", "world", ":-)", "-2"};
if (answer == "a") {
    Console.WriteLine("Введите кол-во элементов массива: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++) {
        Console.WriteLine("Введите " + i + " элемент массива: ");
        array[i] = Console.ReadLine();
    }
}
string[] array2 = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] array2) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if(array[i].Length <= 3) {
            array2[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array, array2);
Console.WriteLine("Готовый массив: ");
PrintArray(array2);