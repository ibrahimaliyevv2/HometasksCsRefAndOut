using System;

namespace HometasksCsRefAndOut
{
    class Program
    {

        
        static void Main(string[] args)
        {
            #region Hometask-1 Addition
            //int[] numbers = { 12, 13, 14, 15 };
            //int num = 16;
            //AddNumber(ref numbers, num);
            #endregion

            #region Hometask-2 Addition
            //string str = "Elimerdan bey Topcubasov";
            //string print = RemoveSpaces(ref str);
            //Console.WriteLine(print);
            #endregion

            #region Hometask-3 Addition
            //int num = 35;
            //Console.WriteLine(NearestSquareRoot(ref num));
            #endregion

            int num = 357;
            Console.WriteLine(LastToFirst(ref num));
        }


        //Hometask-1: Parameter olaraq integer array ve integer qebul eden
        //ve hemin integer value-nu integer array-e yeni element kimi daxil eden metod

        static void AddNumber(ref int[] numbers, int num)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            newNumbers[numbers.Length] = num;
            //Burada size olaraq [newNumbers.Length - 1] de ola biler,
            //cunki numbers.Length ile beraberdir.
            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = numbers[i];
            }
            numbers = newNumbers;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }


        //Hometask-2: Parameter olaraq bir string deyer qebul edir ve ondaki bosluqlari silir
        //Meselen, "Hikmet Abbasov" --> "HikmetAbbasov"

        static string RemoveSpaces(ref string text)
        {
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newText += text[i];
                }
            }
            text = newText;
            return text;
        }


        //Hometask-3: Qebul etdiyi integer hemin parametrin deyerinin en yaxin kokalti
        //deyerini menimseden metod
        //Meselen int num=35 versek, bu variable-in yeni deyeri 5 olmalidir/

        static int NearestSquareRoot(ref int num)
        {
            int answer = 0;
            int i = 2;
            if(num == 0 || num == 1)
            {
                return num;
            }
            else if (num > 1)
            {
                while(i*i <= num)
                {
                    answer = i;
                    i++;
                }
                num = answer;
            }
            return num;
        }

        //Hometask-4: Verilmis n ededinin son reqemini onun evveline getirerek yeni bir eded duzeldin
        //(misalcun daxil edilen eded 475 olarsa, geriye 547 qaytarsin).

        static int LastToFirst(ref int num)
        {
            int count = 0;
            int swapped;
            int last = num % 10;
            while (num != 0)
            {
                num /= 10;
                count++;
            }
            int expo = (int)Math.Pow(10,count);



            swapped = ((num - last) / expo) + (last * expo);
            num = swapped;
            return num;
        }
    }
}