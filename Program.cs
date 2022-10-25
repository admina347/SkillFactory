using System;
using System.Collections.Generic;
using System.Linq;

namespace module14
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>( );
          
           companies.Add("Apple", new []{ "Mobile",  "Desktop"  });
           companies.Add("Samsung", new []{ "Mobile"} );
           companies.Add("IBM", new []{ "Desktop" } );
 
           var mobileCompanies = companies
                   // смотрим те из выборки, значения в которых содержат искомое
               .Where(c => c.Value.Contains("Mobile"));
 
           foreach (var company in mobileCompanies)
               Console.WriteLine(company.Key);
        }
    }
}