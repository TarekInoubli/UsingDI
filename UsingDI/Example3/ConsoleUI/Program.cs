using DemoLibrary;

IPerson owner = Factory.CreatePerson();
owner.FirstName = "Peter";
owner.LastName =  "Müller";
owner.EmailAddress = "peter.mueller@company.com";
owner.PhoneNumber = "172 132 9876";

IChore chore = Factory.CreateChore();
chore.ChoreName = "Take out the trash";
chore.Owner = owner;

chore.PerformeWork(3);
chore.PerformeWork(1.5);
chore.CompleteChore();

Console.ReadLine();
