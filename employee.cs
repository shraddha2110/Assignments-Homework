//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class employee
//    {
//        private int accno;
//        private string customername;
//        private double balance;
//        private int loanamt;
//        private static double roi = 9.2;
//        private static int count;
//        public Bank(string customername, double balance, int loanamt)
//        {
//            this.customername = customername;
//            this.balance = balance;
//            this.loanamt = loanamt;
//            count++;
//            accno = count;

//        }
//        public static int DisplayCount() // static method or class method
//        {
//            return count;
//        }
//        public string Print() // concret or instance method
//        {
//            return $"Acc No {accno} , Name {customername}, Balance {balance} Loan Amt {loanamt}, ROI {roi}";
//        }
//    }
//}
