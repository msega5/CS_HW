using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3
{
    
    public class FamilyMember
    {
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        
        void Info(int indent = 0)
        {
            Console.Write($"{this.Name} {new String('+', indent)} ");
        }
        public virtual void Print(int indent = 0)
        {
            Info(indent);
        }
    }
}
