using TriggerMe;

namespace OOP_Day1_Homework;
class Program
{
    static void Main(string[] args)
    {
        #region 01 TimeTable1: Print TimeTable for user input in range of 0 to 255
        TimeTable1 obj1 = new TimeTable1();
        obj1.GetUserInput();
        #endregion

        #region 01 TimeTable2: Print TimeTable (1-12) multiplied by user input in range of 0 to 255
        TimeTable2 obj2 = new TimeTable2();
        obj2.GetUserInput();
        #endregion

        #region 02 VatCalculator: Calculate VAT by Country from a given sale 
        //use switch case
        VatCalculator objVat = new VatCalculator();
        Console.WriteLine(objVat.CaluculateVat(1_000_000, "Armenia"));

        #endregion

        #region 03 ConvertToOrdinal: converts a cardinal int value into an ordinal string value
        ConvertToOrdinal objCard = new ConvertToOrdinal();

        objCard.GetUserInput();

        #endregion

        #region 04 Recursion: Factorial

        #endregion

    }
}