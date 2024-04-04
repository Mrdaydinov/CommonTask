using System.Reflection.Emit;

namespace CommonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Task 1

        Label:
            int input = int.Parse(Console.ReadLine());
            if (!(input > 1 && input < 3999))
            {
                Console.WriteLine("Number must be > 1 and <= 3999");
                goto Label;
            }

            int count = 0;

            int temp = input;
            while (temp > 0)
            {
                temp /= 10;
                count++;
            }


            string romanNum = "";
            

            switch (count)
            {
                case 1:
                    switch (input)
                    {
                        case 1:
                            romanNum = "I";
                            break;
                        case 2:
                            romanNum += "II";
                            break;
                        case 3:
                            romanNum += "III";
                            break;
                        case 4:
                            romanNum += "IV";
                            break;
                        case 5:
                            romanNum += "V";
                            break;
                        case 6:
                            romanNum += "VI";
                            break;
                        case 7:
                            romanNum += "VII";
                            break;
                        case 8:
                            romanNum += "VIII";
                            break;
                        case 9:
                            romanNum += "IX";
                            break;
                    }
                    break;
                case 2:
                    int firstDigCase2 = input / 10;
                    switch (firstDigCase2)
                    {
                        case 1:
                            romanNum = "X";
                            break;
                        case 2:
                            romanNum += "XX";
                            break;
                        case 3:
                            romanNum += "XXX";
                            break;
                        case 4:
                            romanNum += "XL";
                            break;
                        case 5:
                            romanNum += "L";
                            break;
                        case 6:
                            romanNum += "LX";
                            break;
                        case 7:
                            romanNum += "LXX";
                            break;
                        case 8:
                            romanNum += "LXXX";
                            break;
                        case 9:
                            romanNum += "XC";
                            break;
                    }
                    int lastDigCase2 = input % 10;
                    switch (lastDigCase2)
                    {
                        case 1:
                            romanNum += "I";
                            break;
                        case 2:
                            romanNum += "II";
                            break;
                        case 3:
                            romanNum += "III";
                            break;
                        case 4:
                            romanNum += "IV";
                            break;
                        case 5:
                            romanNum += "V";
                            break;
                        case 6:
                            romanNum += "VI";
                            break;
                        case 7:
                            romanNum += "VII";
                            break;
                        case 8:
                            romanNum += "VIII";
                            break;
                        case 9:
                            romanNum += "IX";
                            break;
                    }
                    break;
                case 3:
                    int firstDigCase3 = input / 10 / 10;
                    switch (firstDigCase3)
                    {
                        case 1:
                            romanNum = "C";
                            break;
                        case 2:
                            romanNum += "CC";
                            break;
                        case 3:
                            romanNum += "CCC";
                            break;
                        case 4:
                            romanNum += "CD";
                            break;
                        case 5:
                            romanNum += "D";
                            break;
                        case 6:
                            romanNum += "DC";
                            break;
                        case 7:
                            romanNum += "DCC";
                            break;
                        case 8:
                            romanNum += "DCCC";
                            break;
                        case 9:
                            romanNum += "CM";
                            break;
                    }

                    int sencondDigCase3 = input / 10 % 10;
                    switch (sencondDigCase3)
                    {
                        case 1:
                            romanNum += "X";
                            break;
                        case 2:
                            romanNum += "XX";
                            break;
                        case 3:
                            romanNum += "XXX";
                            break;
                        case 4:
                            romanNum += "XL";
                            break;
                        case 5:
                            romanNum += "L";
                            break;
                        case 6:
                            romanNum += "LX";
                            break;
                        case 7:
                            romanNum += "LXX";
                            break;
                        case 8:
                            romanNum += "LXXX";
                            break;
                        case 9:
                            romanNum += "XC";
                            break;
                    }

                    int lastDigCase3 = input % 10;
                    switch (lastDigCase3)
                    {
                        case 1:
                            romanNum += "I";
                            break;
                        case 2:
                            romanNum += "II";
                            break;
                        case 3:
                            romanNum += "III";
                            break;
                        case 4:
                            romanNum += "IV";
                            break;
                        case 5:
                            romanNum += "V";
                            break;
                        case 6:
                            romanNum += "VI";
                            break;
                        case 7:
                            romanNum += "VII";
                            break;
                        case 8:
                            romanNum += "VIII";
                            break;
                        case 9:
                            romanNum += "IX";
                            break;
                    }
                    break;
                case 4:
                    int firstDigCase4 = input / 10 / 10 / 10;
                    switch (firstDigCase4)
                    {
                        case 1:
                            romanNum = "M";
                            break;
                        case 2:
                            romanNum += "MM";
                            break;
                        case 3:
                            romanNum += "MMM";
                            break;
                    }

                    int secondDigCase4 = input / 10 / 10 % 10;
                    switch (secondDigCase4)
                    {
                        case 1:
                            romanNum += "C";
                            break;
                        case 2:
                            romanNum += "CC";
                            break;
                        case 3:
                            romanNum += "CCC";
                            break;
                        case 4:
                            romanNum += "CD";
                            break;
                        case 5:
                            romanNum += "D";
                            break;
                        case 6:
                            romanNum += "DC";
                            break;
                        case 7:
                            romanNum += "DCC";
                            break;
                        case 8:
                            romanNum += "DCCC";
                            break;
                        case 9:
                            romanNum += "CM";
                            break;
                    }

                    int thirdDigCase4 = input / 10 % 10;
                    switch (thirdDigCase4)
                    {
                        case 1:
                            romanNum += "X";
                            break;
                        case 2:
                            romanNum += "XX";
                            break;
                        case 3:
                            romanNum += "XXX";
                            break;
                        case 4:
                            romanNum += "XL";
                            break;
                        case 5:
                            romanNum += "L";
                            break;
                        case 6:
                            romanNum += "LX";
                            break;
                        case 7:
                            romanNum += "LXX";
                            break;
                        case 8:
                            romanNum += "LXXX";
                            break;
                        case 9:
                            romanNum += "XC";
                            break;
                    }

                    int lastDigCase4 = input % 10;
                    switch(lastDigCase4)
                    {
                        case 1:
                            romanNum += "I";
                            break;
                        case 2:
                            romanNum += "II";
                            break;
                        case 3:
                            romanNum += "III";
                            break;
                        case 4:
                            romanNum += "IV";
                            break;
                        case 5:
                            romanNum += "V";
                            break;
                        case 6:
                            romanNum += "VI";
                            break;
                        case 7:
                            romanNum += "VII";
                            break;
                        case 8:
                            romanNum += "VIII";
                            break;
                        case 9:
                            romanNum += "IX";
                            break;
                    }
                    break;
            }

            Console.WriteLine(romanNum);
        }
    }

}
