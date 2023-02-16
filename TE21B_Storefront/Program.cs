// x Lista med saker man kan köpa
// x Skriva in vilken man ska köpa
// -- Skriva in hur många --
// x Kolla ifall man har råd
// x Dra av pengar

int money = 300;



int[] prices = { 50, 100, 3, -20, 10 };
string[] wares = { "Bananananananana", "Atombomb", "Jeff Bezos", "Bloon", "NES 8-bit" };

while (true)
{
  PrintWares(wares, prices);
  Console.WriteLine("Skriv in siffran för det du vill köpa och tryck Enter:");

  try
  {
    money = MakePurchase(money, prices, wares);
  }
  catch
  {
    Console.WriteLine("Är du dum eller?");
  }

  Console.WriteLine($"Du har {money} pengar kvar");
}

Console.ReadLine();

static void PrintWares(string[] wares, int[] prices)
{
  for (int i = 0; i < prices.Length; i++)
  {
    string name = wares[i];
    int price = prices[i];

    Console.WriteLine($"{i + 1}. {name} [{price}]");
  }
}

static int GetWareNumber()
{
  string whichStr = Console.ReadLine();

  int which = 0;
  int.TryParse(whichStr, out which);

  which--;
  return which;
}

static int MakePurchase(int money, int[] prices, string[] wares)
{
  int which = GetWareNumber();

  int price = prices[which];
  string wareName = wares[which];

  if (money - price > 0)
  {
    Console.WriteLine($"Du köpte en {wareName}");
    money -= price;
  }
  else
  {
    Console.WriteLine("Haha, du är fattig");
  }

  return money;
}