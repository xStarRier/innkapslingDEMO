/*
 * 1: Objekt med begge variablene
 * 2: Trekke ut metoder og flytte inn i klassen
 * 3: Innkapsliing
 * 4: Endre implementasjon
 */

using innkapslingDEMO;

var stats = new Stats();
while(true)
{
    Console.WriteLine("Write a number (or blanked to exit)");
    var numberStr = Console.ReadLine();
    if (string.IsNullOrEmpty(numberStr)) break;
    var number = Convert.ToInt32(numberStr);
    stats.Numbers [stats.NumberCount++] = number;
    stats.NumberCount++;
    var sum = stats.Numbers.Sum();
    Console.WriteLine(
        $"Quantity of numbers: {stats.NumberCount} " +
        $"Summary: {sum} " +
        $"Average: {(float)sum/stats.NumberCount}");
}
