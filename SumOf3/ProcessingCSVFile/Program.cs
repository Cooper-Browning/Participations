using System;
using System.IO;

namespace ProcessingCSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\csbro\Downloads\sales_data_sample.csv
            //right click project, add existing item, click all files, add file, click to open file, go to properties and change to copy always

            string[] lines = File.ReadAllLines("sales_data_sample.csv"); // must set to variable because returning an array of string

            double sum2003 = 0;
            double sum2004 = 0;
            double sum2005 = 0;
            double[] sumMonths = new double[13];
            //sumMonths[0] = 0;    0 isn't a month
            sumMonths[1] = 0;
            sumMonths[2] = 0;
            sumMonths[3] = 0;
            sumMonths[4] = 0;
            sumMonths[5] = 0;
            sumMonths[6] = 0;
            sumMonths[7] = 0;
            sumMonths[8] = 0;
            sumMonths[9] = 0;
            sumMonths[10] = 0;
            sumMonths[11] = 0;
            sumMonths[12] = 0;
   

            for (int i = 1; i < lines.Length; i++) // for loop because want to skip first line that has titles, this is why NOT foreach
            {
                //     0          1               2            3
                //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
                string currentLineOffFile = lines[i];
                string[] pieces = currentLineOffFile.Split(',');
                //       0                1
                //{"ORDERNUMBER", {QUANTITYORDERED},...}
                string status = pieces[6];
                double sales = Convert.ToDouble(pieces[4]);
                int month = Convert.ToInt32(pieces[8]);
                int year = Convert.ToInt32(pieces[9]);

                if (status == "Shipped")
                {
                    sumMonths[month] += sales;
                    switch (year)
                    {
                        case 2003:
                            sum2003 += sales;
                            break;
                        case 2004:
                            sum2004 += sales;
                            break;
                        default: //2005
                            sum2005 += sales;
                            break;
                    }

                }
            } //for
            Console.WriteLine($"The sum for 2003 is {sum2003.ToString("C2")}");
            Console.WriteLine($"The sum for 2004 is {sum2004.ToString("C2")}");
            Console.WriteLine($"The sum for 2005 is {sum2005.ToString("C2")}");

            for (int i = 1; i < sumMonths.Length; i++)
            {
                if (i==1)
                {
                    Console.WriteLine($"The sum for all January's is {sumMonths[i].ToString("C")}");
                }
                else if (i==2)
                {
                    Console.WriteLine($"The sum for all February's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"The sum for all March's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"The sum for all April's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"The sum for all May's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"The sum for all June's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 7)
                {
                    Console.WriteLine($"The sum for all July's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 8)
                {
                    Console.WriteLine($"The sum for all August's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 9)
                {
                    Console.WriteLine($"The sum for all September's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 10)
                {
                    Console.WriteLine($"The sum for all October's is {sumMonths[i].ToString("C")}");
                }
                else if (i == 11)
                {
                    Console.WriteLine($"The sum for all November's is {sumMonths[i].ToString("C")}");
                }
                else //12
                {
                    Console.WriteLine($"The sum for all December's is {sumMonths[i].ToString("C")}");
                }
            }



        }
    }
}
