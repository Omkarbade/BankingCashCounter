using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter
{
    public class CashCounter
    {
        public int Total_Balance_Amount = 100000;
        public int deposit_Amt = 0;
        public int withdraw_Amt = 0;

        Queue queue = new Queue();

        public void Withdraw()
        {
            Console.WriteLine("Total Balance of your account : " +Total_Balance_Amount);

            Console.WriteLine("Please Enter Amount for Withdraw :\n");
            withdraw_Amt = Convert.ToInt32(Console.ReadLine());

            if (withdraw_Amt > Total_Balance_Amount)  //if else loop used for withdrew in that 2 condition;
            {
                Console.WriteLine("Insufficient balance in your account..");
            }
            else
            {
                Total_Balance_Amount -= withdraw_Amt;
                Console.WriteLine(withdraw_Amt + " amount withdrawn from your account \n");
                Console.WriteLine("Your Avaialble Balance is :" +Total_Balance_Amount);
            }
            queue.Dequeue();
        }

        public void Deposit()
        {
            Console.WriteLine("Total Balance of your account : " +Total_Balance_Amount);
            Console.WriteLine("Please Enter Amount for Deposit :\n");
            deposit_Amt = Convert.ToInt32(Console.ReadLine());

            Total_Balance_Amount += deposit_Amt;
            Console.WriteLine(deposit_Amt + " Money depositted in your account \n");
            Console.WriteLine("Now Your Avaialble Balance is :" +Total_Balance_Amount);

            queue.Dequeue();

        }
    }
}
