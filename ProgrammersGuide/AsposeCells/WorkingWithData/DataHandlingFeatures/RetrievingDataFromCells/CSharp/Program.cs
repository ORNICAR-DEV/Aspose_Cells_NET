//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;
using System;

namespace RetrievingDataFromCells
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Opening an existing workbook
            Workbook workbook = new Workbook(dataDir + "book1.xls");
            
            //Accessing first worksheet
            Worksheet worksheet = workbook.Worksheets[0];

            foreach (Cell cell1 in worksheet.Cells)
            {
                //Variables to store values of different data types
                string stringValue;
                double doubleValue;
                bool boolValue;
                DateTime dateTimeValue;

                //Passing the type of the data contained in the cell for evaluation
                switch (cell1.Type)
                {
                    //Evaluating the data type of the cell data for string value
                    case CellValueType.IsString:
                        stringValue = cell1.StringValue;
                        Console.WriteLine("String Value: " + stringValue);
                        break;

                    //Evaluating the data type of the cell data for double value
                    case CellValueType.IsNumeric:
                        doubleValue = cell1.DoubleValue;
                        Console.WriteLine("Double Value: " + doubleValue);
                        break;

                    //Evaluating the data type of the cell data for boolean value
                    case CellValueType.IsBool:
                        boolValue = cell1.BoolValue;
                        Console.WriteLine("Bool Value: " + boolValue);
                        break;

                    //Evaluating the data type of the cell data for date/time value
                    case CellValueType.IsDateTime:
                        dateTimeValue = cell1.DateTimeValue;
                        Console.WriteLine("DateTime Value: " + dateTimeValue);
                        break;

                    //Evaluating the unknown data type of the cell data
                    case CellValueType.IsUnknown:
                        stringValue = cell1.StringValue;
                        Console.WriteLine("Unknown Value: " + stringValue);
                        break;

                    //Terminating the type checking of type of the cell data is null
                    case CellValueType.IsNull:
                        break;
                }

            }

        }
    }
}