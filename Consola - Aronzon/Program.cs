using System;
using System.Linq;

namespace ConsumoWebService2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SOAP.CountryInfoService client = new SOAP.CountryInfoService();

            var respuesta = client.FullCountryInfoAllCountries();
            Console.WriteLine(respuesta.FirstOrDefault().sContinentCode);
            Console.WriteLine(respuesta.FirstOrDefault().sName);
            Console.WriteLine(respuesta.FirstOrDefault().sCapitalCity);
            Console.WriteLine(respuesta.FirstOrDefault().sCountryFlag);
            Console.WriteLine(respuesta.FirstOrDefault().sISOCode);

            Console.Read();

        }
    }
}
