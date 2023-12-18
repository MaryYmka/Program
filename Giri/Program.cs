int numberA = 1;
int numberB = 2;
int numberC = 6;
int numberD = 8;
int numberE = 4;

int max = numberA;

if(numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
if (numberD > max) max = numberD;
if (numberE > max) max = numberE;

Console.Write("max = ");
Console.WriteLine(max);