using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    internal class SoftUniCoursePlanning
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdToken = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (cmdToken[0])
                {
                    case "Add":

                        if (!lessons.Contains(cmdToken[1]))
                        {
                            lessons.Add(cmdToken[1]);
                        }

                        break;
                    case "Insert":

                        if (!lessons.Contains(cmdToken[1]))
                        {
                            lessons.Insert(int.Parse(cmdToken[2]), cmdToken[1]);
                        }

                        break;
                    case "Remove":

                        if (lessons.Contains(cmdToken[1]))
                        {
                            lessons.Remove(cmdToken[1]);
                        }

                        break;
                    case "Exercise":

                        string exerciseName = $"{cmdToken[1]}-Exercise";

                        if (lessons.Contains(cmdToken[1]) && !lessons.Contains(exerciseName))
                        {
                            int lessonIndex = lessons.IndexOf(cmdToken[1]);

                            if (lessonIndex + 1 >= lessons.Count)
                            {
                                lessons.Add(exerciseName);
                            }
                            else
                            {
                                lessons.Insert(lessonIndex + 1, exerciseName);
                            }
                        }
                        else if (!lessons.Contains(cmdToken[1]))
                        {
                            lessons.Add(cmdToken[1]);
                            lessons.Add(exerciseName);
                        }

                        break;
                    case "Swap":

                        if (lessons.Contains(cmdToken[1]) && lessons.Contains(cmdToken[2]))
                        {

                            int lesson1Index = lessons.IndexOf(cmdToken[1]);
                            int lesson2Index = lessons.IndexOf(cmdToken[2]);

                            lessons[lesson1Index] = cmdToken[2];
                            lessons[lesson2Index] = cmdToken[1];

                            string Ex1GoesToEx2 = $"{cmdToken[1]}-Exercise";
                            string Ex2GoesToEx1 = $"{cmdToken[2]}-Exercise";

                            if (lessons.Contains(Ex1GoesToEx2) && lessons.Contains(Ex2GoesToEx1))
                            {
                                lessons[lessons.IndexOf(Ex1GoesToEx2)] = Ex2GoesToEx1;

                                lessons[lessons.IndexOf(Ex2GoesToEx1)] = Ex1GoesToEx2;
                            }

                            else if (lessons.Contains(Ex2GoesToEx1) && !lessons.Contains(Ex1GoesToEx2))
                            {
                                lessons.Remove(Ex2GoesToEx1);
                                if (lesson1Index + 1 > 0 && lesson1Index + 1 < lessons.Count)
                                {
                                    lessons.Insert(lesson1Index + 1, Ex2GoesToEx1);
                                }
                                else if (lesson1Index + 1 >= lessons.Count)
                                {
                                    lessons.Add(Ex2GoesToEx1);
                                }
                            }

                            else if (lessons.Contains(Ex1GoesToEx2) && !lessons.Contains(Ex2GoesToEx1))
                            {
                                lessons.Remove(Ex1GoesToEx2);
                                if (lesson2Index + 1 > 0 && lesson2Index + 1 < lessons.Count)
                                {
                                    lessons.Insert(lesson2Index + 1, Ex2GoesToEx1);
                                }
                                else if (lesson2Index + 1 >= lessons.Count)
                                {
                                    lessons.Add(Ex2GoesToEx1);
                                }
                            }

                        }

                        break;
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}