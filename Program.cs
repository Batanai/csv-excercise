using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead("./Data.csv")), true))
            {
                csvTable.Load(csvReader);
            }
           

            List<Data> data = new List<Data>();

            for (int i = 0; i < csvTable.Rows.Count; i++)  
                {  
                    data.Add(new Data 
                    { 
                        FirstName= csvTable.Rows[i][0].ToString(), 
                        LastName= csvTable.Rows[i][1].ToString(), 
                        Address = csvTable.Rows[i][2].ToString(), 
                        PhoneNumber = csvTable.Rows[i][3].ToString() 
                    });
                    Console.WriteLine();
                    
                }
            
        }
    }
}
