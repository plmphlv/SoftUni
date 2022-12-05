using System;
using System.Collections.Generic;

namespace _03.MessagesManager
{
    internal class MessagesManager
    {
        static void Main(string[] args)
        {

            int messegeLimit = int.Parse(Console.ReadLine());
            Dictionary<string, int> userRecords = new Dictionary<string, int>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Statistics")
            {
                string[] commadArgs = inputLine.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string command = commadArgs[0];

                switch (command)
                {
                    case "Add":

                        string username = commadArgs[1];
                        int sent = int.Parse(commadArgs[2]);
                        int received = int.Parse(commadArgs[3]);

                        if (!userRecords.ContainsKey(username))
                        {
                            userRecords.Add(username, sent + received);
                        }

                        break;
                    case "Message":

                        string sender = commadArgs[1];
                        string receiver = commadArgs[2];

                        if (userRecords.ContainsKey(sender) && userRecords.ContainsKey(receiver))
                        {
                            userRecords[sender] += 1;
                            userRecords[receiver] += 1;

                            if (userRecords[sender] >= messegeLimit)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                Dictionary<string, int> usersCopy = new Dictionary<string, int>();

                                foreach (var item in userRecords)
                                {

                                    if (item.Key != sender)
                                    {
                                        usersCopy.Add(item.Key, item.Value);
                                    }

                                    userRecords = usersCopy;

                                }
                            }

                            if (userRecords[receiver] >= messegeLimit)
                            {
                                Console.WriteLine($"{receiver} reached the capacity!");
                                Dictionary<string, int> usersCopy = new Dictionary<string, int>();

                                foreach (var item in userRecords)
                                {

                                    if (item.Key != receiver)
                                    {
                                        usersCopy.Add(item.Key, item.Value);
                                    }

                                    userRecords = usersCopy;

                                }
                            }

                        }

                        

                        break;
                    case "Empty":

                        string toBeRemoved = commadArgs[1];

                        if (userRecords.ContainsKey(toBeRemoved))
                        {
                            Dictionary<string, int> usersCopy = new Dictionary<string, int>();

                            foreach (var item in userRecords)
                            {

                                if (item.Key != toBeRemoved)
                                {
                                    usersCopy.Add(item.Key, item.Value);
                                }

                            }

                            userRecords = usersCopy;

                        }
                        else if (toBeRemoved == "All")
                        {
                            userRecords.Clear();
                        }

                        break;
                    default:
                        break;
                }
            }



            Console.WriteLine($"Users count: {userRecords.Count}");
            if (userRecords.Count > 0)
            {
                foreach (var user in userRecords)
                {
                    Console.WriteLine($"{user.Key} - {user.Value}");
                }
            }

        }
    }
}