using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithDataLibrary;

namespace TrainingPart2_Task1
{
    class OutputGraphic
    {
        List<double> dataList = new List<double>();
        DataForGraphic dataForGraphic;
        string[,] arrayForDrawing;

        public OutputGraphic(List<double> dataList)
        {
            this.dataList = dataList;
            dataForGraphic = new DataForGraphic(this.dataList);
            arrayForDrawing = dataForGraphic.GetDataForGraphic();
        }

        public void DrawGraphic()
        {
            double verticalScaleDivision = (dataList.Max() - dataList.Min()) / dataList.Count;
            int additionalIndent;
            int maxIndent = dataList.Max().ToString().Length;

            for (int i = 0; i < dataList.Count; i++)
            {
                additionalIndent = Math.Floor(dataList.Max() - verticalScaleDivision * i).ToString().Length;
                Console.Write(Math.Floor(dataList.Max() - verticalScaleDivision * i));

                while (additionalIndent != maxIndent)
                {
                    Console.Write(" ");
                    additionalIndent++;
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
                additionalIndent = Math.Floor(dataList.Min() - verticalScaleDivision).ToString().Length;

                while (additionalIndent != maxIndent)
                {
                    Console.Write(" ");
                    additionalIndent++;
                }

            }
            else
            {
                Console.Write("0");
                additionalIndent = 1;

                while (additionalIndent != maxIndent)
                {
                    Console.Write(" ");
                    additionalIndent++;
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
