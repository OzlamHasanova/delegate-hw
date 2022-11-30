namespace FindAll
{
    internal class Program
    {


        static void Main(string[] args)
        {
            /*int[] arr = { 1, 2, 3, 4 };
            void Add(int value)
            {
                Array.Resize(ref arr, arr.Length-1);
                arr[arr.Length-1] = value;

            }
            bool Sumarr(params int[] arr)
            {
                foreach( int item in arr)
                {
                    
                    if (item > 2)
                    {
                        Console.WriteLine(item);                    }
                }
                return true;
            }
        }
        delegate bool Check(int number);*/

            int[] _arr;
            _arr = new int[0];
           void Add(object value)
            {
                Array.Resize(ref _arr, _arr.Length - 1);
                _arr[_arr.Length - 1] = (int)value;

            }

            int FindAll<T>(T[] arr,Check<T> func)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (func(arr[i]))
                    { 
                        return i;
                    }
            }
                return 0;

            }
            bool Check(int number)
            {
                if(number>2)
                {
                    return true;
                }
                return false;
            }

            Console.WriteLine(FindAll(new int[] {1,2,3,4},Check));
        }

        

        delegate bool Check<T>(T number);
    }

}