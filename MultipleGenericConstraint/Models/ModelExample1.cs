using MultipleGenericConstraint.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleGenericConstraint.Models
{
    public class ModelExample1:IModelExample
    {
        public string attribute1 { get; set; }
        public string attribute2 { get; set; }
    }
}
