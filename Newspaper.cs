using System;

public class Newspaper : Media
{
  
  int newEdition;
  DateTime today = DateTime.Today;

    //Konstruktors mainīgo nosaukšanai
  public Newspaper(string Name,DateTime CreationDate, int NewEdition, int PeopleCount, double AddCost, int AddAmount, string[] Programm, bool Subscription = false,double SubscriptionCost = 0)
  {
    this.mediaType = "Newspaper";    
    this.name = Name;
    this.creationDate = CreationDate;
    this.peopleCount = PeopleCount;
    this.subscription = Subscription;
    this.subscriptionCost = SubscriptionCost;  
    this.addCost = AddCost; 
    this.addAmount = AddAmount; 
    this.programm = Programm; 
    newEdition = NewEdition;
  }


  //Izvadīt informāciju
  public override void PrintInfo(){
    Console.WriteLine($"===============================\n-------Media: {mediaType}-------\n{mediaType} name: {Name}\nDate of creation: {CreationDate.ToString("dd/MM/yyyy")}");
    
  }

  public override void Statistic(){
    Console.WriteLine($"People today: {peopleCount}\nSubscription: {subscription}\nSubscription cost: {subscriptionCost}\nAdd cost: {addCost}\nAdd amount: {addAmount}");

  }

  public override void Profit(){
    double money = peopleCount * subscriptionCost + addCost * addAmount;
    Console.WriteLine($"Money per day: {money}");
  }

  public override void Programme(){
    Console.WriteLine("\n------Newspaper programme------");
    for (int i = 0; i < programm.Length; i++){
      Console.WriteLine($"{i+1}. {programm[i]}");
      
    }
    Console.WriteLine("-------------------------------");
    Console.WriteLine("===============================\n");
  }

  public void NewEditionDate(){
    int daysUntilEdition = (newEdition - (int) today.DayOfWeek + 7) % 7;
    DateTime nextEdition = today.AddDays(daysUntilEdition);
    Console.WriteLine($"New Edition day of week: {nextEdition.ToString("dddd")}\nNew Edition date: {nextEdition.ToString("dd/MM/yyyy")}\n");
  }
}