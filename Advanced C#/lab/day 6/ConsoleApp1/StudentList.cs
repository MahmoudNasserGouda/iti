using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentList : IEnumerable<Student>, IEnumerator<Student>
    {
        private List<Student> _students = new List<Student>();
        private int _currentIndex = -1;

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public Student Current
        {
            get { return _students[_currentIndex]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _students.Count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public void Dispose()
        {
            
        }
    }
}
