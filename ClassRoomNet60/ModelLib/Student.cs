using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.ModelLib
{
    public class Student
    {
        private string _Name;
        private int _Birth_month;
        private int _Birthday;


        public Student(string Name, int Birth_month, int Birthday)
        {

            _Name = Name;
            _Birth_month = Birth_month;
            _Birthday = Birthday;

        }

        public string Name
        {
            get => _Name;
           
        }

        public int Birth_month
        {
            get => _Birth_month;
        }

        public int Birthday
        {
            get => _Birthday;
        }
    }
}
