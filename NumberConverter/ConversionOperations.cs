using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumberConverter
{
    class ConversionOperations
    {
        static IDictionary<string, int> basics = new Dictionary<string, int>
        {
            { "", 0 },
            { "one", 1},
            { "two", 2},
            { "three", 3},
            { "four", 4},
            { "five", 5},
            { "six", 6},
            { "seven", 7},
            { "eight", 8},
            { "nine", 9},
            { "ten", 10},
            { "eleven", 11},
            { "twelve", 12},
            { "thirteen", 13},
            { "fourteen", 14},
            { "fifteen", 15},
            { "sixteen", 16},
            { "seventeen", 17},
            { "eightteen", 18},
            { "nineteen", 19}
        };

        static IDictionary<string, int> tens = new Dictionary<string, int>
        {
            { "", 0 },
            { "twenty", 20},
            { "thirty", 30},
            { "forty", 40},
            { "fifty", 50},
            { "sixty", 60},
            { "seventy", 70},
            { "eighty", 80},
            { "ninety", 90}
        };

        static IDictionary<string, long> highs = new Dictionary<string, long>
        {
            { "", 0},
            { "hundred", 100},
            { "thousand", 1000},
            { "million", 1000000},
            { "billion", 1000000000},
            { "trillion", 1000000000000},
            { "quadrillion", 1000000000000000},
            { "quintillion", 1000000000000000000}
        };

        //Reverse dictionaries are used to change integers to strings
        static IDictionary<int, string> reverseBasics = basics.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
        static IDictionary<int, string> reverseTens = tens.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
        static IDictionary<long, string> reverseHighs = highs.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);

        public long StringtoInt(string input)
        {

            input = input.Replace(" and", "");
            input = input.Replace("a ", "one ");

            int isNegative = 1;

            if (input.Contains("negative"))
            {

                isNegative = -1;
            }

            List<string> wordList = input.Split(new[] { " " }, StringSplitOptions.None).ToList();

            string[] wordArray = wordList.ToArray();

            long index = -1;
            long output = 0;

            //Find the index of the biggest digit indicator e.g. thousand, million...
            for (int i = wordArray.Length - 1; i >= 0; i--)
            {
                if (index != -1 && highs.ContainsKey(wordArray[i]) && highs[wordArray[i]] > highs[wordArray[index]])
                {

                    index = i;
                }
                else if (highs.ContainsKey(wordArray[i]) && index == -1) 
                {

                    index = i;
                }
            }

            //If there are none, then number < 100 and will be directly printed
            if (index == -1)
            {
                for (int i = 0; i < wordArray.Length; i++)
                {
                    if (basics.ContainsKey(wordArray[i]) && i == wordArray.Length - 1)
                    {

                        output += basics[wordArray[i]];
                    }
                    else if (tens.ContainsKey(wordArray[i]))
                    {

                        output += tens[wordArray[i]];
                    }
                }
            }

            else
            {
                //String is divided in two parts from the biggest indicator
                string[] left = splitArray(wordArray, 0, (int)index);
                string[] right = splitArray(wordArray, (int)index + 1, wordArray.Length);

                output += StringtoInt(left, highs[wordArray[index]]) + StringtoInt(right, 1);
            }
            return output * isNegative;
        }

        //This function recursively divides and finds the integer value of the string using method overloading, the reason there is another helper function is to include the multiplier.
        private long StringtoInt(string[] stringArray, long multiplier)
        {
            int index = -1;
            long count = 0;

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                if (index != -1 && highs.ContainsKey(stringArray[i]) &&
                    highs[stringArray[i]] > highs[stringArray[index]])
                {

                    index = i;
                }
                else if (highs.ContainsKey(stringArray[i]) && index == -1)
                {

                    index = i;
                }
            }
            if (index == -1)
            {
                //This is the base case of the recursion
                for (int i = 0; i < stringArray.Length; i++)
                {
                    if (basics.ContainsKey(stringArray[i]) && i == stringArray.Length - 1)
                    {

                        count += basics[stringArray[i]];

                    }
                    else if (tens.ContainsKey(stringArray[i]))
                    {

                        count += tens[stringArray[i]];
                    }
                }

                return count * multiplier;
            }
            else
            {
                string[] left = splitArray(stringArray, 0, index);
                string[] right = splitArray(stringArray, index + 1, stringArray.Length);
                
                return (StringtoInt(left, highs[stringArray[index]]) + StringtoInt(right, 1)) * multiplier;
            }

        }



        public string InttoString(long value, bool isBritish)
        {
            try
            {
                if (value == 0)
                {
                    return "zero";

                }

                string output = "";
                
                if (value < 0)
                {
                    output += "negative ";
                    value *= -1;
                }

                string stringForm = value.ToString();

                if (stringForm.Length >= 3)
                {
                    //Because numbers are arranged in 3 digit parts, these variables find the full 3 digits and the highest ranking digits
                    long numberOfFullDigits = stringForm.Length / 3;
                    long numberOfIncompleteDigits = stringForm.Length % 3;
                    
                    int stringLength = stringForm.Length;
                    
                    long digitCount = (long)Math.Pow(10, numberOfFullDigits * 3);
                    long remainingParts = Int64.Parse(stringForm.Substring((int)numberOfIncompleteDigits, (int)numberOfFullDigits * 3));
                    
                    if (numberOfIncompleteDigits != 0)
                    {
                        //If the number is not in exact multiple of 3, the remainin part is the highest order and written first
                        long first = Int64.Parse(stringForm.Substring(0, (int)numberOfIncompleteDigits));
                        long remainder = first % 10;
                        long ten = first / 10;

                        if (first < 20)
                        {

                            output += reverseBasics[(int)first] + " " + reverseHighs[(long)Math.Pow(10, numberOfFullDigits * 3)] + " ";
                        }
                        else
                        {

                            output += reverseTens[(int)ten * 10] + " " + reverseBasics[(int)remainder] + " " + reverseHighs[(long)Math.Pow(10, numberOfFullDigits * 3)] + " ";
                        }
                    }

                    if (remainingParts == 0)
                    {

                        return output;
                    }

                    for (long i = numberOfIncompleteDigits; i < stringLength; i += 3)
                    {
                        //Send the remaining parts as 3 digit numbers to the helper function
                        int threeDigits = Int32.Parse(stringForm.Substring((int)i, 3));
                        string outputConcat = printParts(threeDigits);
                       
                        output += outputConcat;
                        //digitCount is used to keep track of the number scales and write accourding scales to according indexes of the string
                        digitCount /= 1000;

                        if (reverseHighs.ContainsKey(digitCount) && outputConcat != "")
                        {

                            output += reverseHighs[digitCount] + " ";
                        }
                    }
                }
                else
                {
                    //If the number is 2 or 1 digits print the number 
                    int remainder = (int)value % 10;
                    int ten = (int)value / 10;

                    if (value < 20)
                    {

                        output += reverseBasics[(int)value] + " ";
                    }
                    else
                    {

                        output += reverseTens[ten * 10] + " " + reverseBasics[remainder];
                    }
                }

                if (isBritish == false)
                {

                    return output.Replace(" and", "");
                }
                else
                {

                    return output;
                }
            }
            catch
            {
                Console.WriteLine("There was a problem with numbers");
                return "There was a problem with numbers";
            }
        }

        private string printParts(int value)
        {
            //This helper function prints integers in parts of 3
            if (value == 0)
            {

                return "";
            } 
            
            if (value < 20)
            {

                return reverseBasics[value] + " ";
            }

            string output = "";
           
            int firstRemainder = value / 100;
            int tempValue = value - firstRemainder * 100;
            int secondRemainder = tempValue / 10;
            int thirdRemainder = tempValue - (secondRemainder * 10);
           
            //Because the highest scale we can encounter in a 3 digit number is "hundred", the power is preset to 100
            int power = 100;

            if (firstRemainder == 0)
            {

                power = 0;
            }
            
            //If there is nothing on the hundreds digit of the number, power is set to 0
            if (value < 20)
            {

                output += reverseBasics[value] + " ";
            }
            else if (value >= 20 && value < 100)
            {

                output += reverseTens[secondRemainder * 10] + " " + reverseBasics[thirdRemainder] + " ";
            }
           
            //Add the values in correct form to the output string by checking if they are <20 and <100 for special conditions
            else
            {
                output += reverseBasics[firstRemainder] + " " + reverseHighs[power] + " ";
                if (secondRemainder != 0 || thirdRemainder != 0)
                {
                    if ((secondRemainder * 10 + thirdRemainder) < 20)
                    {

                        output += "and " + reverseBasics[(secondRemainder * 10 + thirdRemainder)] + " ";
                    }
                    else
                    {

                        output += "and " + reverseTens[secondRemainder * 10] + " " + reverseBasics[thirdRemainder] + " ";
                    }
                }
            }

            return output;
        }

        private string[] splitArray(string[] arr, int startIndex, int endIndex)
        {
            string[] newArray = new string[endIndex - startIndex];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = arr[startIndex];
                startIndex++;
            }
            
            return newArray;
        }
    }
}
