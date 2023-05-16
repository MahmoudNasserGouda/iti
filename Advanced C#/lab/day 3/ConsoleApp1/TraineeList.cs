using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct TraineeList
    {
        private Trainee?[] trainees;

        public TraineeList(int capacity)
        {
            trainees = new Trainee?[capacity];
        }

        // First indexer - takes an integer index and assigns a Trainee object at that index
        public Trainee? this[int index]
        {
            get => trainees[index];
            set => trainees[index] = value;
        }

        // Second indexer - takes a string name and searches for a Trainee object with that name
        public Trainee? this[string name]
        {
            get => trainees.FirstOrDefault(t => t?.Name == name);
        }
    }
}
