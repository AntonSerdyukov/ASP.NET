using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Module5_1
{
    class Program
    {       
        static void Main(string[] args)
        {
                      
            do
            {
                int[] dangerCellPositions = new int[10];               
                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {          
                    dangerCellPositions[i]=rnd.Next(1, 99);

                    for (int j = 0; j < i; j++)
                    {
                    
                        if (dangerCellPositions[i] == dangerCellPositions[j])
                        {                           
                            i--;                           
                        }
                    
                    }

                }

                int[,] cellDamage = new int[10, 10];

                for (int rowNum = 0; rowNum < 10; rowNum++)
                {
                
                    for (int columnNum = 0; columnNum < 10; columnNum++)
                    {
                        cellDamage[rowNum, columnNum] = 0;

                        for (int dangerCellNum = 0; dangerCellNum < dangerCellPositions.Length; dangerCellNum++)
                        {

                            if (rowNum*10+columnNum == dangerCellPositions[dangerCellNum])
                            {
                                cellDamage[rowNum,columnNum] = rnd.Next(1, 11);
                            }

                        }   
                        
                    } 
                    
                }

                int currentRow = 0;
                int currentColumn = 0;
                int lifePoints = 10;
                Console.WriteLine("Вы находитесь в точке [0,0], принцесса-в точке [9,9].Ваша цель-добраться до принцессы");

                while (lifePoints > 0 && (currentColumn != 9 || currentRow != 9))
                {
                    Console.WriteLine("Выберите номер действия:s-шаг вниз, w-шаг вверх,d-шаг вправо,a-шаг влево");
                    string userStep = Console.ReadLine();

                    switch (userStep)
                    {
                        case "s":
                            currentRow++;
                            break;
                        case "w":
                            currentRow--;
                            break;
                        case "d":
                            currentColumn++;
                            break;
                        case "a":
                            currentColumn--;
                            break;
                        default:
                            Console.WriteLine("Неверно введены данные");
                            break;
                    }

                    if ((currentColumn >= 0 && currentColumn <= 9) && (currentRow >= 0 && currentRow <= 9))
                    {
                        lifePoints -= cellDamage[currentRow , currentColumn];
                        cellDamage[currentRow,currentColumn] = 0;
                    }

                    else
                    {
                        Console.WriteLine("Вы не можете выходить  за границы игрового поля, измените ход");

                        if (currentColumn < 0)
                        {
                            currentColumn++;
                        }

                        else if (currentColumn > 9)
                        {
                            currentColumn--;
                        }

                        else if (currentRow < 0)
                        {
                            currentRow++;
                        }

                        else if (currentRow > 9)
                        {
                            currentRow--;
                        }

                    } 
                        
                }

                if (lifePoints > 0)
                {
                    Console.WriteLine("Вы выиграли, вы спасли принцессу");                   
                }

                else
                {
                    Console.WriteLine("Вы проиграли");
                }
                                            
                Console.WriteLine("Хотите сыграть еще раз? 1-да");
            }
            while (Console.ReadLine() == "1");    
            
        }
    }
}
