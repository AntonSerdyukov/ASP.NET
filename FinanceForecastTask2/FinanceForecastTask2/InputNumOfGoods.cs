namespace FinanceForecastTask2
{
    class InputNumOfGoods
    {
        public int NumOfGoods { get; }

        public InputNumOfGoods(string inputNumOfGoods)
        {

            if (int.TryParse(inputNumOfGoods, out int numOfGoods) == true)
            {
                NumOfGoods = numOfGoods;
            }
            else
            {
                NumOfGoods = -1;
            }

        }

    }
}
