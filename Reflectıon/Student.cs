using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflectıon
{
    internal class Student
    {

        private static int _counter;
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Surname { get; set; }


        public Student()
        {
            _counter = Id;
            _counter++;
            this.Name = Name;
            this.Surname = Surname;

        }


        public void ShovInfo()
        {
            Console.WriteLine($" Ad : {this.Name} Soy ad:  {this.Surname} "  );
        }


    }
}
