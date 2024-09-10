using System;

namespace LAB_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Создать две коллекции ResearchTeamCollection<string>.
            ResearchTeamCollection<string> collection1 = new ResearchTeamCollection<string>() { CollectionName = "Collection_1"};
            ResearchTeamCollection<string> collection2 = new ResearchTeamCollection<string>() { CollectionName = "Collection_2" };
            //2)	Создать объект TeamsJournal, подписать его на события
            //      ResearchTeamsChanged из  обоих объектов
            //      ResearchTeamCollection<string>.

            TeamsJournal teamsJournal = new TeamsJournal();
            collection1.ResearchTeamsChanged += teamsJournal.HandleResearchTeamsChanged;
            collection2.ResearchTeamsChanged += teamsJournal.HandleResearchTeamsChanged;
            

            ResearchTeam team1 = new ResearchTeam("Team_1", 101, "Topic_1", TimeFrame.Year);
            ResearchTeam team2 = new ResearchTeam("Team_2", 102, "Topic_2", TimeFrame.TwoYears);

            team1.PropertyChanged += teamsJournal.PropertyResearchTeamsChanged;
            team2.PropertyChanged += teamsJournal.PropertyResearchTeamsChanged;


            //3)	Внести изменения в коллекции ResearchTeamCollection<string>
            //      добавить элементы в коллекции;
            //      изменить значения разных свойств элементов, входящих в коллекцию;
            //      удалить элемент из коллекции;
            //      изменить данные в удаленном элементе;
            //      заменить один из элементов коллекции;
            //      изменить данные в элементе, который был удален из коллекции при замене элемента.


            collection1.Add("Key1", team1);
            collection1.Add("Key2", team2);
            collection2.Add("Key3", team1);

            team2.NameOfResearch = "UpdatedField";

            collection1.Remove(team1);

            collection2.Replace(team1, new ResearchTeam("Team_3", 104, "Topic_3", TimeFrame.Long));

            team1.NameOfResearch = "UpdatedField2";

            //4)   Вывести данные объекта TeamsJournal
            Console.WriteLine(teamsJournal.ToString());

        }
    }
}