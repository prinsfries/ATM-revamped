using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmBL
{
    public class MoneyService
    {
        public void WITH(int moneymoney, int wd)
        {
            Withdraw(moneymoney, wd);
        }
        public int Withdraw(int moneymoney, int wd)
        {
            
            switch (wd)
            {
                case 1:
                    wd = 100;
                    if (moneymoney >= wd)
                    { 
                        return moneymoney - wd;
                    }
                    else
                    {
                        wd = 0;
                        return wd;
                    }
                    break;
                case 2:
                    wd = 200;
                    if (moneymoney >= wd)
                    {
                        return moneymoney - wd;
                    }
                    else
                    {
                        return moneymoney;
                    }
                    break;
                case 3:
                    wd = 500;
                    if (moneymoney >= wd)
                    {
                        return moneymoney - wd;
                    }
                    else
                    {
                        return moneymoney;
                    }
                    break;
                case 4:
                    wd = 1000;
                    if (moneymoney >= wd)
                    {
                        return moneymoney - wd;
                    }
                    else
                    {
                        return moneymoney;
                    }
                    break;
                case 5:
                    wd = 2000;
                    if (moneymoney >= wd)
                    {
                        return moneymoney - wd;
                    }
                    else
                    {
                        return moneymoney;
                    }
                    break;
                case 6:
                    wd = 5000;
                    if (moneymoney >= wd)
                    {
                        return moneymoney - wd;
                    }
                    else
                    {
                        return moneymoney;
                    }
                    break;
                case 7:
                    wd = 7500;
                    if (moneymoney >= wd)
                    {
                        return moneymoney - wd;
                    }
                    else
                    {
                        return moneymoney;
                    }
                    break;
                case 8:
                    wd = 10000;
                    if (moneymoney >= wd)
                    {
                        return moneymoney - wd;
                    }
                    else
                    {
                        return moneymoney;
                    }
                    break;
                case 9:
                    return customInputWith(moneymoney, wd);
                    break;
                default:
                    return moneymoney;
                    break;
            }
        }
        public void DEPO(int moneymoney, int wd)
        {
            deposit(moneymoney, wd);   
        }
        public int deposit(int moneymoney, int wd)
        {
            switch (wd)
            {
                case 1:
                    wd = 100;
                    return moneymoney + wd;
                    break;
                case 2:
                    wd = 200;
                    return moneymoney + wd;
                    break;
                case 3:
                    wd = 500;
                    return moneymoney + wd;
                    break;
                case 4:
                    wd = 1000;
                    return moneymoney + wd;
                    break;
                case 5:
                    wd = 2000;
                    return moneymoney + wd;
                    break;
                case 6:
                    wd = 5000;
                    return moneymoney + wd;
                    break;
                case 7:
                    wd = 7500;
                    return moneymoney + wd;
                    break;
                case 8:
                    wd = 10000;
                    return moneymoney + wd;
                    break;
                case 9:
                    return customInputDepo(moneymoney, wd);
                    break;

                default:
                    return moneymoney;
                    break;
            }
        }
        public int customInputWith(int moneymoney, int input)
        {
            if (input <= moneymoney)
            {
                return moneymoney - input;
                
            }
            else
            {
                moneymoney=0;
                return moneymoney;
            }
        }
        public int customInputDepo(int moneymoney, int input)
        {
            int inputted = moneymoney + input;
            return inputted;
        }
    }
}
