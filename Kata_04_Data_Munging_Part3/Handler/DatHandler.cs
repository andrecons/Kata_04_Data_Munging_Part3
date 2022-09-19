using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kata_04_Data_Munging_Part3.Objects;

namespace Kata_04_Data_Munging_Part3.Handler;

class DatHandler
{
    protected string datFilePath = "";
    protected string separatorPatternA;
    protected string separatorPatternB;
    protected string separatorPatternC;
    protected int indexColumnA;
    protected int indexColumnB;
    protected int indexColumnC;
    protected List<Row> rowList = new List<Row>();

    public DatHandler() { }

    public void PathPrinter() { Console.WriteLine(datFilePath); }

    public void Importer()
    {

        string[] separator = { separatorPatternA, separatorPatternB, separatorPatternC };

        try
        {
            using (var textFile = System.IO.File.OpenText(datFilePath))
            {
                Console.WriteLine("File at " + datFilePath + " found.\n");
                string line = "";

                while ((line = textFile.ReadLine()) != null)
                {

                    string[] lineToArray = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    int i = 0;

                    try
                    {
                        string teamOrDay = lineToArray[indexColumnA];
                        decimal firstColumn = Decimal.Parse(lineToArray[indexColumnB].Replace('*', ' '));
                        decimal secondColumn = Decimal.Parse(lineToArray[indexColumnC].Replace('*', ' '));
                        Row newRow = new Row();
                        newRow.SettId(teamOrDay);
                        newRow.SetFirstColumn(firstColumn);
                        newRow.SetSecondColumn(secondColumn);
                        rowList.Add(newRow);
                        Console.WriteLine(newRow.ToString());

                    }
                    catch (Exception e)
                    {

                        //Console.WriteLine(e.Message);

                    }

                    //Console.WriteLine("****EndOfLine****");
                }
            }
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }
    }

    public decimal GetSmallestSpread()
    {
        decimal smallestSpread = 10000;

        foreach (Row row in rowList)
        {
            if (row.GetSpread() < smallestSpread)
            {
                smallestSpread = row.GetSpread();
            }
        }
        return smallestSpread;
    }

    public string[] GetIndexSmallerSpread()
    {
        int sameSpreadDaysCounter = 0;

        foreach (Row row in rowList)
        {
            if (row.GetSpread() == GetSmallestSpread())
            {
                sameSpreadDaysCounter++;
            }
        }

        string[] teamIndex = new string[sameSpreadDaysCounter];

        decimal smallestSpread = GetSmallestSpread();

        int arrayIndex = 0;

        foreach (Row singleRow in rowList)
        {
            if (singleRow.GetSpread() == smallestSpread)
            {
                teamIndex[arrayIndex] = singleRow.GetId();
                arrayIndex++;
            }
        }

        return teamIndex;
    }
}
