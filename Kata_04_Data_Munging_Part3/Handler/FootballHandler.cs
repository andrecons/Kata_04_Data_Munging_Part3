using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_04_Data_Munging_Part3.Handler;

class FootballHandler : DatHandler
{
    private string[] separator = { " ", " - ", "." };


    public FootballHandler()
    {
        this.datFilePath = @"..\..\..\InputFiles\football.dat";
        this.separatorPatternA = " ";
        this.separatorPatternB = "-";
        this.separatorPatternC = ".";
        this.indexColumnA = 1;
        this.indexColumnB = 6;
        this.indexColumnC = 7;
        //string[] separator = { " ", "-", "." };
    }

}
