using System;
namespace Backend2.Services
{
    public interface ICalculation
    {
        int firstNum { get; set; }
        int secondNum { get; set; }

         int Sum(int firstNum, int secondNum);

         int Sub(int firstNum, int secondNum);

         int Multiplication(int firstNum, int secondNum);

         int Division(int firstNum, int secondNum);
        
    }
}
