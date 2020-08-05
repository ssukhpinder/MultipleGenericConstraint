using MultipleGenericConstraint.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleGenericConstraint.Models
{
    public class ModelExample2 : IModelExample
    {
        private string _attribute1;
        private string _attribute2;
        public string attribute1 { get => "ModelExample 2 attribute 1"; set => _attribute1 = value; }
        public string attribute2 { get => "ModelExample 2 attribute 2"; set => _attribute2 = value; }
    }
}
