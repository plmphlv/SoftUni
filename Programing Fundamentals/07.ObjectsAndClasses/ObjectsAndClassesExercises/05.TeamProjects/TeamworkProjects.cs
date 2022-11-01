using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamProjects
{
    internal class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            while (numberOfTeams > 0)
            {

                string[] teamCreationsCmd = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

                Team newProjectTeam = teams.FirstOrDefault(x => x.TeamName == teamCreationsCmd[1]||x.CreatorName== teamCreationsCmd[0]);

                if (newProjectTeam == null)
                {

                    newProjectTeam = new Team(teamCreationsCmd[0], teamCreationsCmd[1]);

                    teams.Add(newProjectTeam);

                    Console.WriteLine($"Team {newProjectTeam.TeamName} has been created by {newProjectTeam.CreatorName}!");

                    numberOfTeams--;
                }
                else if (newProjectTeam.TeamName == teamCreationsCmd[1])
                {
                    Console.WriteLine($"Team {newProjectTeam.TeamName} was already created!");
                }
                else if(newProjectTeam.CreatorName == teamCreationsCmd[0])
                {
                    Console.WriteLine($"");
                }


            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] teamCmdArgs = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();



            }
        }
    }

    class Team
    {

        public Team(string creatorName, string teamNanme)
        {
            CreatorName = creatorName;
            TeamName = teamNanme;
            TeamMembers = new List<string>();
        }

        public string CreatorName { get; private set; }
        public string TeamName { get; private set; }
        public List<string> TeamMembers { get; private set; }


        public void AddNewTeamMember(ref List<string> teamMembers, string newMember)
        {
            teamMembers.Add(newMember);
        }

    }

}