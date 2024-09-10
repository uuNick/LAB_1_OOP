using System;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Создать две коллекции ResearchTeamCollection

            ResearchTeamCollection researchTeamCollection_1 = new ResearchTeamCollection() { NameOfCollection = "Collection 1"};
            ResearchTeamCollection researchTeamCollection_2 = new ResearchTeamCollection() { NameOfCollection = "Collection 2"};

            ResearchTeam researchTeam4 = new ResearchTeam("Org 1", 100, "1 Topic", TimeFrame.Year);
            ResearchTeam researchTeam3 = new ResearchTeam("Org 2", 101, "2 Topic", TimeFrame.Long);
            ResearchTeam researchTeam2 = new ResearchTeam("Org 3", 102, "3 Topic", TimeFrame.TwoYears);
            ResearchTeam researchTeam1 = new ResearchTeam("Org 4", 103, "4 Topic", TimeFrame.Year);
            ResearchTeam researchTeamAdded_1 = new ResearchTeam("Org 5", 104, "5 Topic", TimeFrame.Year);
            ResearchTeam researchTeamAdded_2 = new ResearchTeam("Org 6", 105, "6 Topic", TimeFrame.Long);
            ResearchTeam researchTeamInserted_1 = new ResearchTeam("Org 7", 106, "7 Topic", TimeFrame.TwoYears);
            ResearchTeam researchTeamInserted_2 = new ResearchTeam("Org 8", 107, "8 Topic", TimeFrame.Year);


            researchTeamCollection_1.Add(researchTeam1);
            researchTeamCollection_1.Add(researchTeam2);
            researchTeamCollection_2.Add(researchTeam3);
            researchTeamCollection_2.Add(researchTeam4);


            //Console.WriteLine(researchTeamCollection_1.ToString());

            //2. 2)	Создать два объекта типа TeamsJournal, один объект TeamsJournal
            //подписать на события ResearchTeamAdded и ResearchTeamInserted из
            //первой коллекции ResearchTeamCollection,
            //другой объект TeamsJournal подписать на события ResearchTeamInserted
            //из обеих коллекций ResearchTeamCollection.

            TeamsJournal teamsJournal_1 = new TeamsJournal();
            TeamsJournal teamsJournal_2 = new TeamsJournal();

            researchTeamCollection_1.ResearchTeamAdded += teamsJournal_1.ResearchTeamAdded;
            researchTeamCollection_1.ResearchTeamInserted += teamsJournal_1.ResearchTeamlnserted;


            researchTeamCollection_1.ResearchTeamInserted += teamsJournal_2.ResearchTeamlnserted;
            researchTeamCollection_2.ResearchTeamInserted += teamsJournal_2.ResearchTeamlnserted;


            //3. 3)	Внести изменения в коллекции ResearchTeamCollection
            //добавить элементы в коллекции;
            //с помощью метода InsertAt(int j, ResearchTeam rt) перед элементом с номером j,
            //который есть в коллекции, вставить новый элемент;
            //вызвать метод InsertAt(int j, ResearchTeam rt) с номером j, которого нет в коллекции.

            researchTeamCollection_1.Add(researchTeamAdded_1); //Вызыввается обработчик ResearchTeamAdded

            researchTeamCollection_1.InsertAt(0, researchTeamInserted_1); //Вызывается обработчик ResearchTeamlnserted
            researchTeamCollection_2.InsertAt(0, researchTeamInserted_2); //Вызывается обработчик ResearchTeamlnserted

            researchTeamCollection_1.InsertAt(10, researchTeamInserted_2); //Вызыввается обработчик ResearchTeamAdded
            researchTeamCollection_2.InsertAt(10, researchTeamInserted_1); //Вызыввается обработчик ResearchTeamAdded

            //4. Вывести данные обоих объектов TeamsJournal.

            Console.WriteLine("Journal 1:\n" + teamsJournal_1.ToString());
            Console.WriteLine("Journal 2:\n" + teamsJournal_2.ToString());

        }
    }
}