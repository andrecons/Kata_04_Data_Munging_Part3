using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_04_Data_Munging_Part3.Handler;

class WeatherHandler : DatHandler
{
    private string[] separator = { " " };

    public WeatherHandler()
    {
        this.datFilePath = @"..\..\..\InputFiles\weather.dat";
        this.separatorPatternA = " ";
        this.separatorPatternB = "";
        this.separatorPatternC = "";
        this.indexColumnA = 0;
        this.indexColumnB = 1;
        this.indexColumnC = 2;
        
    }

}
