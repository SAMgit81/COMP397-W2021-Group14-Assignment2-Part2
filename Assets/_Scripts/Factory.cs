using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Scripts
{
    public class Class1 
    {

    }

    public class Class2
    {

    }
    public class Factory
    {
        public void GetType(string value)
        {
            switch (value)
            {
                case "value1":
                    //return new Class1
                    break;
                case "value2":
                    //return new Class2
                    break;
                default:
                    //return null;
                    break;
            }

        }
    }

    
}
