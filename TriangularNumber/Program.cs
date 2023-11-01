int startNumber, toNumber;
 
Console.WriteLine("First Number: ");
try
{
    startNumber = Convert.ToInt32(Console.ReadLine());

}
catch
{
    Console.WriteLine("bad Input...");
    return;
}
Console.WriteLine("Second Number: ");
try
{
    toNumber = Convert.ToInt32(Console.ReadLine());

}
catch
{
    Console.WriteLine("bad Input...");
    return;
}
if (startNumber > toNumber)
{
    Console.WriteLine("start number should be less than to number");
}
Console.WriteLine("--------------------------------------------");
Calc(startNumber, toNumber);
Console.WriteLine("--------------------------------------------");


void Calc(int startNum, int toNum)
{
    Console.WriteLine((startNum * (startNum + 1))/2);
    if (startNum == toNum) return;
    Calc(startNum + 1, toNum);
}