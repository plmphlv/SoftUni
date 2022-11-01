using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamProjects
{
    internal class TeamworkProjects
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();

            CreateTeams(teams);
            MemberSplit(teams);
            PrintTeamsInList(teams);

        }
        public static void CreateTeams(List<Team> teams)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTeams; i++)
            {

                string[] teamCreationsCmd = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Team newProjectTeam = teams.FirstOrDefault(x => x.TeamName == teamCreationsCmd[1] || x.CreatorName == teamCreationsCmd[0]);

                if (newProjectTeam == null)
                {

                    newProjectTeam = new Team(teamCreationsCmd[0], teamCreationsCmd[1]);

                    teams.Add(newProjectTeam);

                    Console.WriteLine($"Team {newProjectTeam.TeamName} has been created by {newProjectTeam.CreatorName}!");

                }
                else if (newProjectTeam.TeamName == teamCreationsCmd[1])
                {
                    Console.WriteLine($"Team {newProjectTeam.TeamName} was already created!");
                }
                else if (newProjectTeam.CreatorName == teamCreationsCmd[0])
                {
                    Console.WriteLine($"{teamCreationsCmd[0]} cannot create another team!");
                }

            }

        }
        public static void MemberSplit(List<Team> teams)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] teamCmdArgs = command
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                if (!CheckIfTeamExists(teams, teamCmdArgs[1]))
                {
                    Console.WriteLine($"Team {teamCmdArgs[1]} does not exist!");
                    continue;
                }
                else if (AlreadyAMemberOfATeam(teams, teamCmdArgs[0]))
                {
                    Console.WriteLine($"Member {teamCmdArgs[0]} cannot join team {teamCmdArgs[1]}!");
                    continue;
                }
                else
                {
                    Team teamToJoin = teams
                       .First(t => t.TeamName == teamCmdArgs[1]);
                    teamToJoin.AddMember(teamCmdArgs[0]);
                }




            }

        }

        public static bool CheckIfTeamExists(List<Team> teams, string teamName)
        {
            return teams.Any(x => x.TeamName == teamName);
        }

        static bool AlreadyAMemberOfATeam(List<Team> teams, string user)
        {
            bool member = teams.Any(t => t.Members.Contains(user));
            bool leader = teams.Any(t => t.CreatorName == user);

            return member || leader;

        }


        public static void PrintTeamsInList(List<Team> teams)
        {

            List<Team> validTeams = teams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName).ToList();
            foreach (Team team in validTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"-{team.CreatorName}");
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"--{member}");
                }
            }

            List<Team> teamsToDisband = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName).ToList();
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }


        }
    }

    class Team
    {
        private readonly List<string> members;

        public Team(string creatorName, string teamName)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            members = new List<string>();
        }

        public string TeamName { get; private set; }
        public string CreatorName { get; private set; }


        public List<string> Members
            => this.members;

        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }

    }

}