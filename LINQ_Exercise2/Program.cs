using System.Linq;



string[] favGamesList = new string[]
    { "Crisis Core: Final Fantasy 7",
      "Final Fantasy 7",
      "Final Fantasy 7: Remake",
      "Final Fantasy 8",
      "Final Fantasy 9",
      "Final Fantasy 10/10-2",
      "Final Fantasy 12",
      "Final Fantasy 13/13-2/13-3",
      "Final Fantasy 15",
      "Persona 3: P3P",
      "Persona 4: Golden",
      "Persona 5: Royal",
      "Diablo 3"};

favGamesList.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine($"   {x}\n      ******   ")); //length ascending
favGamesList.OrderByDescending(x => x.Length).ToList().ForEach(x => Console.WriteLine($"   {x}\n      ******   ")); //length descending