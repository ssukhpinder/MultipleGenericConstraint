using MultipleGenericConstraint.Interface;
using MultipleGenericConstraint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleGenericConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Call to Multiple generic constraints single & multiple class name
            MultipleGenericExample1<ModelExample3, ModelExample1>();
            MultipleGenericExample1<ModelExample3, ModelExample2>();

            //Below calls will result is error because T1 can only accept models of type ModelExample3
            //MultipleGeneric<ModelExample1, ModelExample2>(); 
            //MultipleGeneric<ModelExample2, ModelExample2>();
            #endregion

            #region Call to Mutiple generic constraint with single class names

            MultipleGenericExample2<ModelExample3, ModelExample2>();

            #endregion
        }

        //Declaring multiple Generic with single & multiple class names using interface
        public static void MultipleGenericExample1<T1, T2>() where T1 : ModelExample3, new() where T2 : IModelExample, new()
        {
            T1 t1 = new T1();
            T2 t2 = new T2();            
        }

        //Declaring multiple generic with single class names
        public static void MultipleGenericExample2<T1, T2>() where T1 : ModelExample3, new() where T2 : ModelExample2, new()
        {
            T1 t1 = new T1();
            T2 t2 = new T2();
        }

    }
}
