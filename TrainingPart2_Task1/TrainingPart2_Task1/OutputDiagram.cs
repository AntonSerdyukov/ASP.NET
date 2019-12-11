using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithDataLibrary;

namespace TrainingPart2_Task1
{
    class OutputDiagram
    {
        List<double> dataList = new List<double>();
        DataForDiagram dataForDiagram;
        string[,] arrayForDrawing;

        public OutputDiagram(List<double> dataList)
        {
            this.dataList = dataList;
            dataForDiagram = new DataForDiagram(this.dataList);
            arrayForDrawing = dataForDiagram.GetDataForDiagram();
        }
         
        public void DrawDiagram()
        {
            double verticalScaleDivision = (dataList.Max() - dataList.Min()) / dataList.Count;
            int maxIndent = dataList.Max().ToString().Length;
            int stringLength;

            for (int i = 0; i < dataList.Count; i++)
            {
                stringLength = Math.Floor(dataList.Max() - verticalScaleDivision * i).ToString().Length;
                Console.Write(Math.Floor(dataList.Max() - verticalScaleDivision * i));

                while (stringLength != maxIndent)
                {
                    Console.Write(" ");
                    stringLength++;
                }

                Console.Write("|");

                for (int j = 0; j < dataList.Count; j++)
                {
                    Console.Write(arrayForDrawing[i, j]);
                }

                Console.WriteLine();
            }

            if (Math.Floor(dataList.Min() - verticalScaleDivision) >= 0)
            {
                Console.Write(Math.Floor(dataList.Min() - verticalScaleDivision));
                stringLength = Math.Floor(dataList.Min() - verticalScaleDivision).ToString().Length;

                while (stringLength != maxIndent)
                {
                    Console.Write(" ");
                    stringLength++;
                }

            }
            else
            {
                Console.Write("0");
                stringLength = 1;

                while (stringLength != maxIndent)
                {
                    Console.Write(" ");
                    stringLength++;
                }

            }

            Console.Write("|");

            for (int j = 0; j < dataList.Count; j++)
            {
                Console.Write("---");
            }

            Console.WriteLine();
        }

    }
}
