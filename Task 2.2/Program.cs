using Task_2._2;

Developer firstDeveloper = new Developer("Vasyl Vasylenko");
Developer secondDeveloper = new Developer("Taras Ivanenko");
Manager firstManager = new Manager("Maksym Maksymenko");
Team firstTeam = new Team("The best team");

firstDeveloper.FillWorkDay();
secondDeveloper.FillWorkDay();
firstManager.FillWorkDay();

firstTeam.AddWorker(firstDeveloper);
firstTeam.AddWorker(secondDeveloper);
firstTeam.AddWorker(firstManager);

firstTeam.ShowDetailedTeamInfo();