using System;


namespace TrainingPart2_Task1
{
    class NumOfPairsInput
    {       

        public int InputNumOfPairs()
        {
            Console.WriteLine("Введите количество пар доход-расход");
            bool isNumOfPairsCorrect = int.TryParse(Console.ReadLine(), out int numOfPairs);

            if (isNumOfPairsCorrect == true && numOfPairs > 0)
            {
                return numOfPairs;
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
                return InputNumOfPairs();
            }

        }

    }
}
