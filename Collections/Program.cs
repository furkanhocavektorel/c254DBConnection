using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void listeler()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("a");
            list.Clear();

            list.Single();
            list.First();
            list.Contains("a");

            list.Equals(new List<String>());

            list.SingleOrDefault();
            list.FirstOrDefault();
            ArrayList a= new ArrayList();

            a.Add("a");
            a.Add(3);

            var cc = 3;
            cc = 5;
            cc = "sa";


            HashSet<String> set = db.getProducts();
            set.Add("a");
            set.Add("b");

            String metin = "as";

            metin = metin+"sadasdsa";


            HashSet<String> set2 = new HashSet<String>();
            set2.Add("a");
            set2.Add("a");


            set.Remove("a");
            set.Clear();

            set.Contains("a");
            set.Equals(set2);
            // FIFO - first in first out
            Queue<String> q = new Queue<String>();
            q.Dequeue();

            // LIFO -> last in first out
            Stack<String> stack = new Stack<String>();


            Dictionary<String, String> testD = new Dictionary<string, List<Student>>;


        }




    }
}
