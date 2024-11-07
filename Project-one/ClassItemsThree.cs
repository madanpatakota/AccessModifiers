using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_one
{

    // 1. wen you are going to create the instance

    //   Classes do't have relationship
    class ClassFive 
    {

        void BankDetails()
        {
            ClassSix classSix = new ClassSix();
            classSix.bankName = "HDFC";
            classSix.bankId = 123;

            //classSix.bankEmpName = "emp1";
        }


    }
    class ClassSix
    {

        internal string bankName;
        internal int bankId;

        protected string bankEmpName;

    }
}
