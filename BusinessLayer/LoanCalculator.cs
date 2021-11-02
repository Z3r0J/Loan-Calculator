using System;

namespace BusinessLayer
{
    public class LoanCalc
    {

        public double LoanOperation(double amount, int Month, int TypeLoan) {

            double total = 0;
            double percent = 0;
            switch (TypeLoan)
            {
                case (int)LoanEnum.Personal:
                    percent = (amount * 22) / 100;
                    total = (percent + amount) / Month;
                    break;

                case (int)LoanEnum.Auto:
                    percent = (amount * 12) / 100;
                    total = (percent + amount) / Month;
                    break;
                case (int)LoanEnum.Mortgage:
                    percent = (amount * 8) / 100;
                    total = (percent + amount) / Month;
                    break;
                default:
                    break;
            }

            return total;
        }
    }
}
