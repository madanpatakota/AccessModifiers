using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_one
{
    class Car
    {
        private string engine;
        private string speed;
        private string price;
        private string brandName;

        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }
    }


    //model are designed by the classes .

    // Car model

    // Engine , Speed , Price , Brand
    class GetAndSetAccessors
    {

        //public string StudentName; //field
        private string name;

       // public string Name { get; set; }  //Property

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        
        //Property
        public string StudentName{
            get { return name; }
            //set { };
            set
            {
                Console.WriteLine("Test");
                if (value == "12345")
                {
                    Console.WriteLine("PLeaase give the proper name. Do't give 12345 like that");
                }
                else
                {
                    name = value;
                }
            }
        }   


    }
    class GetSetProgram
    {
        static void Main()
        {
            GetAndSetAccessors getAndSetAccessors = new GetAndSetAccessors();
            Console.WriteLine(getAndSetAccessors.StudentName); //No Name

            getAndSetAccessors.StudentName = "yuyy";  // you cannot set the value

            Console.ReadLine();


            Car car = new Car();
            car.Engine = "12345tgUUHH";


        }
    }
}
