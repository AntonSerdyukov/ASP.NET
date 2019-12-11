﻿using System;
using System.Collections.Generic;


namespace TrainingPart2_Task1
{
    class IncomeInput
    {
        List<double> incomes;

        public IncomeInput(List<double> incomes)
        {
            this.incomes = incomes;
        }

        public void Input()
        {
            Console.WriteLine("Введите доход");
            bool isIncomeCorrect = double.TryParse(Console.ReadLine().Replace(".", ","), out double inputIncome);

            if (isIncomeCorrect == true && inputIncome >= 0)
            {
                incomes.Add(inputIncome);
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
                Input();
            }

        }

        public List<double> Incomes
        {

            get
            {
                return incomes;
            }
               
        }

    }
}
