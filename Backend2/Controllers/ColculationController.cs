using System;
using Backend2.Models;
using Backend2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend2.Controllers
{
    public class ColculationController : Controller
    {
        private readonly ICalculation calculation;

        public ColculationController(ICalculation calculation)
        {
            this.calculation = calculation;
        }

        public ActionResult Manual()
        {
            if (this.Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                string result = "";
                string num1 = this.Request.Form["Num1"];
                if (String.IsNullOrEmpty(num1))
                {
                    this.ViewBag.Error1 = "first number is required";
                    return this.View();
                }
                int saveNum1 = int.Parse(num1);

                string num2 = this.Request.Form["Num2"];
                if (String.IsNullOrEmpty(num2))
                {
                    this.ViewBag.Error2 = "Second number is required";
                    return this.View();
                }
                String Op = this.Request.Form["Op"];

                if (Op == "/" && num2 == "0")
                {
                    this.ViewBag.Error3 = "Can't divide by Zero";
                    return this.View();
                }

                int saveNum2 = int.Parse(num2);



                if (Op == "+")
                {
                    result = calculation.Sum(saveNum1, saveNum2) + "";
                }
                else if (Op == "-")
                {
                    result = calculation.Sub(saveNum1, saveNum2) + "";
                }
                else if (Op == "/")
                {
                    result = calculation.Division(saveNum1, saveNum2) + "";
                }
                else if (Op == "*")
                {
                    result = calculation.Multiplication(saveNum1, saveNum2) + "";
                }

                var resultModel = new ColculationModel()
                {
                    firstNum = saveNum1,
                    secondNum = saveNum2,
                    Result = result
                };
                return this.View("Result", resultModel);
            }

            return this.View();
        }
        [HttpGet]
        public ActionResult ManualWithSeparateHandlers()
        {
            return this.View();
        }

        [HttpPost, ActionName("ManualWithSeparateHandlers")]
        [ValidateAntiForgeryToken]
        public ActionResult ManualWithSeparateHandlersConfirm()
        {


            string result = "";
            string num1 = this.Request.Form["Num1"];
            if (String.IsNullOrEmpty(num1))
            {
                this.ViewBag.Error1 = "first number is required";
                return this.View();
            }
            int saveNum1 = int.Parse(num1);

            string num2 = this.Request.Form["Num2"];
            if (String.IsNullOrEmpty(num2))
            {
                this.ViewBag.Error2 = "Second number is required";
                return this.View();
            }
            String Op = this.Request.Form["Op"];

            if (Op == "/" && num2 == "0")
            {
                this.ViewBag.Error3 = "Can't divide by Zero";
                return this.View();
            }

            int saveNum2 = int.Parse(num2);



            if (Op == "+")
            {
                result = calculation.Sum(saveNum1, saveNum2) + "";
            }
            else if (Op == "-")
            {
                result = calculation.Sub(saveNum1, saveNum2) + "";
            }
            else if (Op == "/")
            {
                result = calculation.Division(saveNum1, saveNum2) + "";
            }
            else if (Op == "*")
            {
                result = calculation.Multiplication(saveNum1, saveNum2) + "";
            }


            var resultModel = new ColculationModel()
            {
                firstNum = saveNum1,
                secondNum = saveNum2,
                Result = result
            };
            return this.View("Result", resultModel);
        }


        public ActionResult ModelBindingInParameters()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ModelBindingInParameters(string Num1, string Num2)
        {
            string result = "";
            if (String.IsNullOrEmpty(Num1))
            {
                this.ViewBag.Error1 = "first number is required";
                return this.View();
            }
            int saveNum1 = int.Parse(Num1);


            if (String.IsNullOrEmpty(Num2))
            {
                this.ViewBag.Error2 = "Second number is required";
                return this.View();
            }


            String Op = this.Request.Form["Op"];
            if (Op == "/" && Num2 == "0")
            {
                this.ViewBag.Error3 = "Can't divide by Zero";
                return this.View();
            }

            int saveNum2 = int.Parse(Num2);



            if (Op == "+")
            {
                result = calculation.Sum(saveNum1, saveNum2) + "";
            }
            else if (Op == "-")
            {
                result = calculation.Sub(saveNum1, saveNum2) + "";
            }
            else if (Op == "/")
            {
                result = calculation.Division(saveNum1, saveNum2) + "";
            }
            else if (Op == "*")
            {
                result = calculation.Multiplication(saveNum1, saveNum2) + "";
            }


            var resultModel = new ColculationModel()
            {
                firstNum = saveNum1,
                secondNum = saveNum2,
                Result = result
            };
            return this.View("Result", resultModel);
        }
        
    }
}

