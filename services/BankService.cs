namespace bank.services
{
    class BankService
    {
        static double getRate(double totalAmount, int durationInMonth)
        {
            double rate = 0.0;
            if(totalAmount <= 5_000_000)
            {
                if (durationInMonth <= 12) rate = 2.0;
                else if (durationInMonth <= 24) rate = 3.0;
                else rate = (durationInMonth / 5);
            }
            else
            {
                if (durationInMonth <= 12) rate = 1.5;
                else if (durationInMonth <= 24) rate = 2.5;
                else rate = (durationInMonth / 6.5);
            }
            return rate;
        }
        public static double getAmountPerPeriod(double totalAmount, int durationInMonth, int periodicity)
        {
            double ret = ((totalAmount * periodicity) / durationInMonth);
            return ret;
        }
        public static double getAmountPerPeriodWithRate(double totalAmount, int durationInMonth, int periodicity)
        {
            double rate = getRate(totalAmount, durationInMonth);
            double amountPerPeriod = getAmountPerPeriod(totalAmount, durationInMonth, periodicity);
            return (amountPerPeriod * (1 + (rate / 100)));
        }
    }
}
