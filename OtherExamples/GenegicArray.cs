namespace OtherExamples
{
    internal class GenegicArray<K>
    {
        K[] mass = new K[10];
        public void AddProducts(K obj)
        {

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] != null)
                {

                }
                else
                {
                    mass[i] = obj;
                }
            }

        }

        public K[] GetArray()
        {
            return mass;
        }
    }
}
