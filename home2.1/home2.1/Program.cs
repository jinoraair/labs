using System;

class Program
{
    static void Main()
    {
        //читаем данные из файла
        FileStream fstream = File.OpenRead("C:\\Users\\762\\Desktop\\Марланд\\home2.1\\input.txt");
        byte[] array = new byte[fstream.Length];
        fstream.Read(array, 0, array.Length);
        //декодируем байты в строку
        string TextFromFile = System.Text.Encoding.Default.GetString(array);
        Console.WriteLine($"Текст из файла: {TextFromFile}");
        fstream.Close();
        //Будем искать слово "hello"
        string str = "hello";       
        int c = Search(TextFromFile, str);
        if (c == 0)
        {
            Console.WriteLine("Подстрока не найдена.");
        }
        else
        {
            Console.WriteLine($"Количество вхождений подстроки {str} в S: {c}");
        }
            
    }
    static int Search(string S, string S1)
    {
        int count = 0;
        S = S.ToLower();
        S1 = S1.ToLower();
        int index = S.IndexOf(S1);

        while (index!= -1)
        {
            count += 1;
            index = S.IndexOf(S1, index + S1.Length);
        }
        
        return count;
        
    }
    
}
