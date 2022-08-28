using System;

namespace StreamOfLetters
{
    internal class StreamOfLetters
    {
        static void Main(string[] args)
        {
            string codeWord = "";
            string codePhrase = "";
            string comand;
            char symbols;
            int cLogger = 0;
            int oLogger = 0;
            int nLogger = 0;
            int wordInterval = 0;
            while ((comand = Console.ReadLine()) != "End")
            {
                symbols = char.Parse(comand);

                if (symbols == 'c' && cLogger == 0)
                    cLogger++;
                else if (symbols == 'o' && oLogger == 0)
                    oLogger++;
                else if (symbols == 'n' && nLogger == 0)
                    nLogger++;
                else
                {
                    switch (symbols)
                    {
                        case 'A':
                        case 'a':
                        case 'B':
                        case 'b':
                        case 'C':
                        case 'c':
                        case 'D':
                        case 'd':
                        case 'E':
                        case 'e':
                        case 'F':
                        case 'f':
                        case 'G':
                        case 'g':
                        case 'H':
                        case 'h':
                        case 'I':
                        case 'i':
                        case 'J':
                        case 'j':
                        case 'K':
                        case 'k':
                        case 'L':
                        case 'l':
                        case 'M':
                        case 'm':
                        case 'N':
                        case 'n':
                        case 'O':
                        case 'o':
                        case 'P':
                        case 'p':
                        case 'Q':
                        case 'q':
                        case 'R':
                        case 'r':
                        case 'S':
                        case 's':
                        case 'T':
                        case 't':
                        case 'U':
                        case 'u':
                        case 'V':
                        case 'v':
                        case 'W':
                        case 'w':
                        case 'X':
                        case 'x':
                        case 'Y':
                        case 'y':
                        case 'Z':
                        case 'z':
                            codeWord += symbols;
                            break;
                        default:
                            break;
                    }
                }


                if (cLogger > 0 && oLogger > 0 && nLogger > 0)
                {
                    if (wordInterval == 0)
                        codePhrase += codeWord;

                    else
                        codePhrase += " " + codeWord;

                    codeWord = String.Empty;
                    cLogger = 0;
                    oLogger = 0;
                    nLogger = 0;
                    wordInterval++;
                }
            }

            Console.WriteLine(codePhrase);
        }
    }
}
