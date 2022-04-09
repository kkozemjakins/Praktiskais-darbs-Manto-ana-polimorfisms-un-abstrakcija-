using System;

class Program {
  public static void Main (string[] args) {
    string[] newspaper_programm = {"News", "Health", "Jokes", "Crosswords"};
    string[] television_programm = {"Films", "News", "Fazenda", "Once Upon a Time in Russia", "Naruto: Shippuden", "Good night kids!", "Medības un makšķerēšana"};
    
    Newspaper newspaper = new Newspaper("Saturday",Convert.ToDateTime("2005.08.17"), 6, 1000, 20.50, 10, newspaper_programm);
    Television television = new Television("THT",Convert.ToDateTime("2006.10.20"), 1000, 120.60, 10, television_programm);

    newspaper.PrintInfo();
    newspaper.NewEditionDate();
    newspaper.Statistic();
    newspaper.Profit();
    newspaper.Programme();
      
    television.PrintInfo();
    television.Statistic();
    television.Profit();
    television.Programme();
  }
}