using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static bool isValidBrackets(string str) {
            int count1, count2, count3;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == '(') {
                    count1 = count2 = count3 = 0;
                    int r = i;
                    while (r<str.Length&&str[r] != ')') {
                        if (str[r] == '(')
                            count1++;
                        else if (str[r] == '{')
                            count2++;
                        else if (str[r] == '}')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r++;
                    }
                    while (count1 > 0&&r<str.Length) {
                        if(str[r]=='('){
                            count1++;
                        }else if (str[r] == ')')
                            count1--;
                        else if (str[r] == '{')
                            count2++;
                        else if (str[r] == '}')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r++;
                    }
                    if (count1 != 0 || count2 != 0 || count3 != 0)
                        return false;
                }else if (str[i] == ')') {
                    count1 = count2 = count3 = 0;
                    int r = i;
                    while (r >= 0 && str[r] != '(') {
                        if (str[r] == ')')
                            count1++;
                        else if (str[r] == '{')
                            count2++;
                        else if (str[r] == '}')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r--;
                    }
                    while (r >= 0 && count1 > 0) {
                        if (str[r] == '(')
                        {
                            count1--;
                        }
                        else if (str[r] == ')')
                            count1++;
                        else if (str[r] == '{')
                            count2++;
                        else if (str[r] == '}')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r--;
                    }
                    if (count1 != 0 || count2 != 0 || count3 != 0)
                        return false;

                }else if (str[i] == '{') {
                    count1 = count2 = count3 = 0;
                    int r = i;
                    while (r < str.Length && str[r] != '}')
                    {
                        if (str[r] == '{')
                            count1++;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r++;
                    }
                    while (count1 > 0 && r < str.Length)
                    {
                        if (str[r] == '{')
                        {
                            count1++;
                        }
                        else if (str[r] == '}')
                            count1--;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r++;
                    }
                    if (count1 != 0 || count2 != 0 || count3 != 0)
                        return false;
                }else if (str[i] == '}') {
                    count1 = count2 = count3 = 0;
                    int r = i;
                    while (r >= 0 && str[r] != '{') {
                        if (str[r] == '}')
                            count1++;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r--;
                    }
                    while (r >= 0 && count1 > 0) {
                        if (str[r] == '{')
                        {
                            count1--;
                        }
                        else if (str[r] == '}')
                            count1++;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '[')
                            count3++;
                        else if (str[r] == ']')
                            count3--;
                        r--;
                    }
                    if (count1 != 0 || count2 != 0 || count3 != 0)
                        return false;


                }else if (str[i] == '['){
                    count1 = count2 = count3 = 0;
                    int r = i;
                    while (r < str.Length && str[r] != ']')
                    {
                        if (str[r] == '[')
                            count1++;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '{')
                            count3++;
                        else if (str[r] == '}')
                            count3--;
                        r++;
                    }
                    while (count1 > 0 && r < str.Length)
                    {
                        if (str[r] == '[')
                        {
                            count1++;
                        }
                        else if (str[r] == ']')
                            count1--;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '{')
                            count3++;
                        else if (str[r] == '}')
                            count3--;
                        r++;
                    }
                    if (count1 != 0 || count2 != 0 || count3 != 0)
                        return false;

                }else if (str[i] == ']'){
                    count1 = count2 = count3 = 0;
                    int r = i;
                    while (r >= 0 && str[r] != '[')
                    {
                        if (str[r] == ']')
                            count1++;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '{')
                            count3++;
                        else if (str[r] == '}')
                            count3--;
                        r--;
                    }
                    while (r >= 0 && count1 > 0)
                    {
                        if (str[r] == '[')
                        {
                            count1--;
                        }
                        else if (str[r] == ']')
                            count1++;
                        else if (str[r] == '(')
                            count2++;
                        else if (str[r] == ')')
                            count2--;
                        else if (str[r] == '{')
                            count3++;
                        else if (str[r] == '}')
                            count3--;
                        r--;
                    }
                    if (count1 != 0 || count2 != 0 || count3 != 0)
                        return false;
                }

            }
                return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("([])[]({}) = " + isValidBrackets("([])[]({})"));
            Console.WriteLine("([)] = " + isValidBrackets("([)]"));
            Console.WriteLine("((() = " + isValidBrackets("((()"));
            Console.WriteLine("([])[][({]}) = " + isValidBrackets("([])[][({]})"));
            Console.WriteLine("[(][)] = " + isValidBrackets("[(][)]"));
            Console.WriteLine("(()()) = " + isValidBrackets("(()())"));
            string abc = "";
            while (true) {
                Console.WriteLine("Enter bracets or exit to exit");
                abc = Console.ReadLine();
                if (abc.Equals("exit"))
                    break;
                Console.WriteLine(abc+" = " + isValidBrackets(abc)+"\n");
            }
            Console.ReadLine();
        }
    }
}

