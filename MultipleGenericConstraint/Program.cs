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
            #region Model Definition
            ModelExample3 modelExample3 = new ModelExample3()
            {
                attribute1 = "test 1",
                attribute2 = "test 2"
            };

            ModelExample2 modelExample2 = new ModelExample2();

            ModelExample1 modelExample1 = new ModelExample1();
            #endregion

            #region Call to Multiple generic constraints single & multiple class name
            MultipleGenericExample1<ModelExample3, ModelExample1>(modelExample3, modelExample1);
            MultipleGenericExample1<ModelExample3, ModelExample2>(modelExample3, modelExample2);

            //Below calls will result is error because T1 can only accept models of type ModelExample3
            //MultipleGeneric<ModelExample1, ModelExample2>(); 
            //MultipleGeneric<ModelExample2, ModelExample2>();
            #endregion

            #region Call to Mutiple generic constraint with single class names

            MultipleGenericExample2<ModelExample3, ModelExample2>();

            #endregion

            Console.ReadLine();
        }

        //Simple Generic Example
        public static void SimpleGenericExample<T>(T model)
        {

        }

        //Declaring multiple Generic with single & multiple class names using interface
        public static void MultipleGenericExample1<T1, T2>(T1 t1, T2 t2) where T1 : ModelExample3, new() where T2 : IModelExample
        {
            Console.WriteLine(String.Format("T1 Attributes {0}  {1}", t1.attribute1, t1.attribute2));
            Console.WriteLine(String.Format("T2 Attributes {0}  {1}", t2.attribute1, t2.attribute2));            
        }

        //Declaring multiple generic with single class names
        public static void MultipleGenericExample2<T1, T2>() where T1 : ModelExample3, new() where T2 : ModelExample2, new()
        {
        }

    }
}
