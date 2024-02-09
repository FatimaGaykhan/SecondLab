//int a = 10;
//int b = 15;

//a= a+b;
//b = a-b;
//a = a - b;

//Console.WriteLine( a);
//Console.WriteLine(b);
//string word = "mexonicome";
//string first = "";
//string second = "";

//for (int i = 0; i < word.Length; i++)
//{
//	if (i < 2)
//	{
//		first += word[i];

//	}
//	else if (i > word.Length - 3)
//	{
//		second += word[i];
//	}
//}

//if (first == second)
//{
//	Console.WriteLine("Beraberdir");
//}
//else
//{
//	Console.WriteLine("Beraber Deyil");
//}

//int[] arr = { 2, 4, 16, 33, 38,100 };

//int result =0;

//for (int i = 1; i < arr.Length; i++)
//{
//    int temp = 0;
//        temp = arr[i] - arr[i-1];

//    if (temp>result)
//    {
//        result = temp;
//    }
//}
//Console.WriteLine(result);

//int n = 120;
//int m = 40;
//int result = 0;

//int max = 0;

//if (n>m)
//{
//    max = n;
//}
//else
//{
//    max = m;
//}

//for (int i = 1; i < max; i++)
//{
//    int temp = 0;
//    if (m % i == 0 && n % i == 0)
//    {
//        temp = i;
//    }
//    if (temp > result)
//    {
//        result = temp;
//    }

//}
//Console.WriteLine(result);


//int n = 12 ;
//int m = 18;
//int max = 0;

//if (n > m)
//{
//    max = n;
//}
//else
//{
//    max = m;
//}

//for (int i = 1; i < max; i++)
//{
//    int temp = max*i;


//    if (temp%n==0 && temp%m==0)
//    {
//        Console.WriteLine(temp);
//        break;
//    }


//}

//int[] arr = { 2, 5, 7, 9, 3, 15, 76, 45 };

//int result = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i]%2==0 && arr[i] > result)
//    {
//        result = arr[i];
//    }
//}
//Console.WriteLine( result);

//int[] arr = { 2, 5, 7, 9, 3, 15, 76, 45,50 };

//int result = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 5 == 0 && arr[i] % 2 == 1 && arr[i] > result)
//    {
//        result = arr[i];
//    }
//}
//Console.WriteLine(result);

//string word = "1001";

//string newWord = "";

//for (int i = word.Length; i < 0; i--)
//{
//    newWord += word[i];

//}

//for (int i = word.Length-1; i >=0; i--)
//{
//    newWord += word[i];
//}

//Console.WriteLine(word == newWord);

//string sentence = "Hello HoW Are You";
//char space = ' ';
//int count = 0;


//for(int i = 0; i < sentence.Length; i++)
//{
//    if (sentence[i]!=space)
//    {
//        count++;
//    }
//}
//Console.WriteLine( count );
