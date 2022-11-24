namespace Lesson11OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, string> dic = new Dictionary<int, string>();
                dic.Add(1, "yarin");
                dic.Add(2, "sdf");
                dic.Remove(1);// remove by key

                Console.WriteLine(dic[1]);

                
                //foreach (var item in dic)
                //{
                //    Console.WriteLine(item);
                //}


                

                List<int> listInt = new List<int>();
                listInt.Add(1);
                listInt.Add(2);
                listInt.Add(3);

                List<string> listString = new List<string>();
                listString.Add("sdf");
                listString.Add("yarin");
                listString.Add("aa");
                listString[0] = "yarin";
                listString[1] = "yy";

                listString.RemoveAt(0);// remove by index
                listString.Remove("aa");// remove by item
                foreach (var item in listString)
                {
                    Console.WriteLine(item);
                }


                // list int
                //listInt[0] = 33;

                // foreach (var item in listInt)
                // {
                //     Console.WriteLine(item);
                // }

            }
            catch (Exception ex)
            {

                Console.WriteLine("error!");
            }

         
        }
    }
}