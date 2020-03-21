using System;
namespace Backend2.Services
{
    public class CalculationService : ICalculation
    {
        public int firstNum { get; set; }
        public int secondNum { get; set; }

        public int Sum(int firstNum,int secondNum)
        {
            return (firstNum + secondNum);
        }
        public int Sub(int firstNum, int secondNum)
        {
            return (firstNum - secondNum);
        }
        public int Multiplication(int firstNum, int secondNum)
        {
            return (firstNum * secondNum);
        }
        public int Division(int firstNum, int secondNum)
        {
            return (firstNum / secondNum);
        }
    }
}
