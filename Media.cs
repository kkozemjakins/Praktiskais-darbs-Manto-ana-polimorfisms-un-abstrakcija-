using System;

public abstract class Media
{
  protected string[] programm;// televizija/laikraksta programme
  public string[] Programm {get {return programm;} }
  
  protected int addAmount;//reklamas skaits
  public int AddAmount {get {return addAmount;} }
  
  protected double addCost;//reklamas cena
  public double AddCost {get {return addCost;} }
  
  protected double subscriptionCost;//televizija/laikraksta cena
  public double SubscriptionCost {get {return subscriptionCost;} }
    
  protected bool subscription;//Ir vai nav abonements
  public bool Subscription {get {return subscription;} }
  
  protected int peopleCount;//cilveku skaits
  public int PeopleCount {get {return peopleCount;} }
  
  protected string name;//media nosaukums
  public string Name {get {return name;} }

  protected DateTime creationDate;//media date creation
  public DateTime CreationDate {get {return creationDate;} }

  protected string mediaType;//media type - television/newspaper
  public string MediaType {get {return mediaType;} }

  public abstract void Profit();//ieņēmumi

  public abstract void Programme();//medijas programma

  public virtual void PrintInfo(){//basic info par media
    Console.WriteLine($"-------Media: {mediaType}-------\n{mediaType} name: {Name}\nDate of creation: {CreationDate.ToString("dd/MM/yyyy")}");
    
  }

  public virtual void Statistic(){//statistika
    Console.WriteLine($"People today: {peopleCount}\nSubscription: {subscription}\nSubscription cost: {subscriptionCost}\nAdd cost: {addCost}\nAdd amount: {addAmount}");

    
  }

}