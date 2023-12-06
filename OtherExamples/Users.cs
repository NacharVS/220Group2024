using System.Collections;

namespace OtherExamples
{
    internal class Users : IEnumerable
    {

        string[] array1 = new string[] { "Bob", "Tom", "Jeff", "Sam", "Bill" };

        public IEnumerator coll => GetEnumerator();

        public IEnumerator GetEnumerator()
        {
            return array1.GetEnumerator();
        }
    }
}
