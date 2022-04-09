using System;

public class Television : Media
{

  public Television(string Name,DateTime CreationDate, int PeopleCount, double AddCost, int AddAmount, string[] Programm, bool Subscription = false,double SubscriptionCost = 0){
    this.mediaType = "Television";    
    this.name = Name;
    this.creationDate = CreationDate;
    this.peopleCount = PeopleCount;
    this.subscription = Subscription;
    this.subscriptionCost = SubscriptionCost;  
    this.addCost = AddCost; 
    this.addAmount = AddAmount; 
    this.programm = Programm; 



  }

  public override void Profit(){
    double money = peopleCount * subscriptionCost + addCost * addAmount;
    Console.WriteLine($"Money per day: {money}");
  }
    //Konstruktors mainīgo nosaukšanai
  public override void Programme(){
    TimeSpan CurrentTime = DateTime.Now.TimeOfDay;
    TimeSpan OurUTC = new TimeSpan(3,00,00);
    CurrentTime = CurrentTime.Add(OurUTC);
    TimeSpan NewTime = new TimeSpan(24,00,00);
    TimeSpan TimeForPrint = new TimeSpan(00,00,00);
    TimeSpan Interval = NewTime.Divide(programm.Length);

    int CurrentProgramm = -1;
  
    Console.WriteLine("\n-----Television  programme-----");
    for (int i = 0; i < programm.Length; i++){
      Console.WriteLine($"{i+1}. ({TimeForPrint.ToString(@"hh\:mm\:ss")}-{(TimeForPrint.Add(Interval)).ToString(@"hh\:mm\:ss")}) {programm[i]}");
      
      if(TimeSpan.Compare(CurrentTime, TimeForPrint) >= 0 && TimeSpan.Compare(CurrentTime, TimeForPrint.Add(Interval)) == -1){
        CurrentProgramm = i;
      }
      TimeForPrint = TimeForPrint.Add(Interval);
    }
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"Current programme is {programm[CurrentProgramm]}");
    Console.WriteLine("===============================");

  }
  //Izvadīt informāciju
  public override void PrintInfo(){
    Console.WriteLine($"===============================\n-------Media: {mediaType}-------\n{mediaType} name: {Name}\nDate of creation: {CreationDate.ToString("dd/MM/yyyy")}");
    
  }

  public override void Statistic(){
    Console.WriteLine($"\nPeople today: {peopleCount}\nSubscription: {subscription}\nSubscription cost: {subscriptionCost}\nAdd cost: {addCost}\nAdd amount: {addAmount}");

  }
}