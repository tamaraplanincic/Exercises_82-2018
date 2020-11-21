using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ExerciseResult
    {
        public ExerciseResult(int iD, string name, string index, int points)
        {
            ID = iD;
            Name = name;
            Index = index;
            Points = points;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Index { get; set; }
        public int Points { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} Name: {Name} Index: {Index} Points: {Points}";
        }
    }
    
}
