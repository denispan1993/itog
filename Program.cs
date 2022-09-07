
Console.Clear();
Console.WriteLine(@"Введите строки через запятую в следующем формате: ""hello"",""2"",""world"","":-)"" или в формате: hello,2,world,:-) ");
//Считываем строку из консоли и заполняем массив строками
string[] readLineArray = FillMyArray(Console.ReadLine());
//Проверяем какие строки меньше либо равны 3 символа и возвращаем массив
string[] testLineArray = TestLineArray(readLineArray);
//Распечатываем новый массив
PrintStringArray(testLineArray);

//Разбиваем строку на массив строк по ,
string[] FillMyArray(string readLineArray) 
{ 
     //Разбиваем строку по , на массив
     string[] inArray = readLineArray.Split(',');
     return inArray;
}

//Тестируем входной массив строк, какие строки меньше либо равны 3 символа
string[] TestLineArray(string[] inArray) 
{  
    string[] outArray = new string[0]; 
    //Получаем длину массива
    int lenght = inArray.Length;
    int counterNewArray = 0;
    for(int count = 0; count < lenght; count++)
    {  //убираем кавычки если они введены 
       string trimElement = inArray[count].Trim('"');
       //проверяем условие, есть ли длина строки  3 или меньше символа
       if (trimElement.Length <= 3) counterNewArray++;  
    }
    // Есть такие элементы, формируем новый массив
    if (counterNewArray > 0) 
    {
         outArray = new string[counterNewArray]; 
        int countNewArray = 0;
        for(int count = 0; count < lenght; count++)
        {  
            //убираем кавычки если они изначально введены
            string trimElement = inArray[count].Trim('"');
            //Проверяем длину строки
            if (trimElement.Length <= 3) 
            {
                outArray[countNewArray] = inArray[count];
                countNewArray++; 
            }
             
        }
        
    } 

    return outArray; 
}

//Метод распечатки результата
void PrintStringArray(string[] inArray)
{
    Console.WriteLine("Итоговый массив:");
    int i = 0;

    while(i < inArray.Length - 1)
    {
        Console.Write(inArray[i]+",");
        i++;
    }
    Console.WriteLine(inArray[i]);
}

 


