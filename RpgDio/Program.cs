using RpgDio.src.entities;

Wizard jennica = new Wizard("Jennica", 24, "Wizard", 400, 300);
Knight arus = new Knight("Arus", 53, "Knight", 600, 200);
Ninja ninja = new Ninja("Ninja", 45, "Ninja", 500, 200);
BlackWizard blackWizard = new BlackWizard("Black Wizard", 48, "Black Wizard", 450, 300);

Console.WriteLine(jennica);
Console.WriteLine(ninja);
Console.WriteLine(blackWizard);
Console.WriteLine(arus);
Console.WriteLine(arus.Attack());