using System.Text;

namespace CalculatorAndAccountManagementTask3
{
    class Calculator<T1, T2> : ICalculator<T1, T2>
    {
        public string GetSum(T1 a, T2 b)
        {

            if (typeof(T1).Name == "String" || typeof(T1).Name == "Object" || typeof(T2).Name == "String" || typeof(T2).Name == "Object")
            {
                return a.ToString() + b.ToString();
            }
            else if (bool.TryParse(a.ToString(), out bool firstBoolValue) == true && bool.TryParse(b.ToString(), out bool secondBoolValue) == true)
            {

                if (firstBoolValue == false && secondBoolValue == false)
                {
                    return "false";
                }

                return "true";
            }
            else if (char.TryParse(a.ToString(), out char firstCharValue) && char.TryParse(a.ToString(), out char secondCharValue))
            {
                return (firstCharValue + secondCharValue).ToString();
            }
            else if (double.TryParse(a.ToString(), out double firstDoubleValue) == true && double.TryParse(b.ToString(), out double secondDoubleValue) == true)
            {
                return (firstDoubleValue + secondDoubleValue).ToString();
            }
            else if (double.TryParse(a.ToString(), out firstDoubleValue) == true && char.TryParse(b.ToString(), out secondCharValue) == true)
            {
                return (firstDoubleValue + secondCharValue).ToString();
            }
            else if (char.TryParse(a.ToString(), out firstCharValue) == true && double.TryParse(b.ToString(), out secondDoubleValue) == true)
            {
                return (firstCharValue + secondDoubleValue).ToString();
            }

            return "Такие типы данных не поддерживаются";
        }

        public string GetDelta(T1 a, T2 b)
        {

            if (typeof(T1).Name == "String" || typeof(T1).Name == "Object" || typeof(T2).Name == "String" || typeof(T2).Name == "Object")
            {

                if (a.ToString() == b.ToString())
                {
                    return string.Empty;
                }
                else
                {
                    return a.ToString();
                }

            }
            else if (bool.TryParse(a.ToString(), out bool firstBoolValue) == true && bool.TryParse(b.ToString(), out bool secondBoolValue) == true)
            {

                if (firstBoolValue == secondBoolValue)
                {
                    return string.Empty;
                }

                return firstBoolValue.ToString();
            }
            else if (char.TryParse(a.ToString(), out char firstCharValue) && char.TryParse(b.ToString(), out char secondCharValue))
            {
                return (firstCharValue - secondCharValue).ToString();
            }
            else if (char.TryParse(a.ToString(), out firstCharValue) && double.TryParse(b.ToString(), out double secondDoubleValue))
            {
                return (firstCharValue - secondDoubleValue).ToString();
            }
            else if (double.TryParse(a.ToString(), out double firstDoubleValue) && char.TryParse(b.ToString(), out secondCharValue))
            {
                return (firstDoubleValue - secondCharValue).ToString();
            }
            else if (double.TryParse(a.ToString(), out firstDoubleValue) == true && double.TryParse(b.ToString(), out secondDoubleValue) == true)
            {
                return (firstDoubleValue - secondDoubleValue).ToString();
            }

            return "Такие типы данных не поддерживаются";
        }

        public string GetMultiply(T1 a, T2 b)
        {

            if (char.TryParse(a.ToString(), out char firstCharValue) && char.TryParse(b.ToString(), out char secondCharValue))
            {
                return (firstCharValue * secondCharValue).ToString();
            }
            else if (char.TryParse(a.ToString(), out firstCharValue) && double.TryParse(b.ToString(), out double secondDoubleValue))
            {
                return (firstCharValue * secondDoubleValue).ToString();
            }
            else if (double.TryParse(a.ToString(), out double firstDoubleValue) && char.TryParse(b.ToString(), out secondCharValue))
            {
                return (firstDoubleValue * secondCharValue).ToString();
            }
            else if (double.TryParse(a.ToString(), out firstDoubleValue) == true && double.TryParse(b.ToString(), out secondDoubleValue) == true)
            {
                return (firstDoubleValue * secondDoubleValue).ToString();
            }
            else if ((typeof(T1).Name == "String" || typeof(T1).Name == "Object") && long.TryParse(b.ToString(), out long secondLongValue))
            {
                string multString = a.ToString();

                for (long i = 0; i < secondLongValue; i++)
                {
                    multString += a.ToString();
                }

                return multString;
            }
            else if (bool.TryParse(a.ToString(), out bool firstBoolValue) == true && bool.TryParse(b.ToString(), out bool secondBoolValue) == true)
            {

                if (firstBoolValue == true && secondBoolValue == true)
                {
                    return "true";
                }

                return "false";
            }

            return "Такие типы данных не поддерживаются";
        }

        public string GetDivide(T1 a, T2 b)
        {

            if (char.TryParse(a.ToString(), out char firstCharValue) && char.TryParse(b.ToString(), out char secondCharValue))
            {

                if (secondCharValue != 0)
                {
                    return (firstCharValue / secondCharValue).ToString();
                }
                else
                {
                    return "Деление на ноль невозможно";
                }

            }
            else if (char.TryParse(a.ToString(), out firstCharValue) && double.TryParse(b.ToString(), out double secondDoubleValue))
            {

                if (secondDoubleValue != 0)
                {
                    return (firstCharValue / secondDoubleValue).ToString();
                }
                else
                {
                    return "Деление на ноль невозможно";
                }

            }
            else if (double.TryParse(a.ToString(), out double firstDoubleValue) && char.TryParse(b.ToString(), out secondCharValue))
            {

                if (secondCharValue != 0)
                {
                    return (firstDoubleValue / secondCharValue).ToString();
                }
                else
                {
                    return "Деление на ноль невозможно";
                }

            }
            else if (double.TryParse(a.ToString(), out firstDoubleValue) == true && double.TryParse(b.ToString(), out secondDoubleValue) == true)
            {

                if (secondDoubleValue != 0)
                {
                    return (firstDoubleValue / secondDoubleValue).ToString();
                }
                else
                {
                    return "Деление на ноль невозможно";
                }

            }
            else if ((typeof(T1).Name == "String" || typeof(T1).Name == "Object") && int.TryParse(b.ToString(), out int secondIntValue) == true)
            {

                if (secondIntValue > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    int lengthOfStrings;

                    if (a.ToString().Length % secondIntValue == 0)
                    {
                        lengthOfStrings = a.ToString().Length / secondIntValue;
                    }
                    else
                    {
                        lengthOfStrings = a.ToString().Length / secondIntValue + 1;
                    }

                    for (int i = 0; i < secondIntValue; i++)
                    {

                        if (i != secondIntValue - 1)
                        {

                            for (int j = i * lengthOfStrings; j < (i + 1) * lengthOfStrings; j++)
                            {
                                sb.Append(a.ToString()[j]);
                            }

                            sb.Append("+");
                        }
                        else if (i == secondIntValue - 1)
                        {

                            for (int j = i * lengthOfStrings; j < a.ToString().Length; j++)
                            {
                                sb.Append(a.ToString()[j]);
                            }

                        }

                    }

                    return sb.ToString();
                }
                else
                {
                    return "Деление на ноль невозможно";
                }

            }

            return "Типы данных не соответствуют их описанию или они не поддерживаются";
        }
    }
}
