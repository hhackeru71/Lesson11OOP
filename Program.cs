namespace Lesson11OOP
{
    internal class Program
    {
        static void ChangeObjectByAge(Person person)
        {
            person.Age = 50;
        }
        static void ChangeNum(int num)
        {
            num = 2;
        }
        static void Main(string[] args)
        {
            try
            {
                //ליצור בנתיב מסויים שתבחרו קובץ בשם newFile.txt
                //לאחר מכן לכתוב לקובץ "this is new file 
                //בדיקה במידה והקובץ קיים או שלא קיים 
                //לקרוא מתוך הקובץ ולהדפיס במסך את הטקסט של הקובץ
                //להעתיק את הקובץ שיצרנו לתיקייה אחרת בשם אחר של הקובץ 
                //

                string data = "123";
                string path = @"C:\Users\yarin\Desktop\האקר יו לימודים\c# oop\Lesson11OOP\bin\Debug\net6.0\yarin.txt";
                string destPath = @"C:\Users\yarin\Desktop\האקר יו לימודים\c# oop\Lesson11OOP\bin";
                if (!File.Exists(path))
                {
                    File.Create("yarin.txt");
                    File.WriteAllText(path, data);

                }
                else
                {
                    File.Move(path, destPath+@"\yarin2344.txt"); 
                    File.Copy(path,destPath+@"\yarin1234.txt");
                    File.WriteAllText(path,data);
                    Console.WriteLine(File.ReadAllText(path));
                    //Console.WriteLine("the file is exists");
                }
               



















                ////דוגמא 
                ////-----------------------------------
                //// value type
                ////int num = 1;
                ////Console.WriteLine(num);
                ////ChangeNum(num);
                ////Console.WriteLine(num);
                ////--------------------------------------------

                ////-----------------------------------------
                ////refrence type
                //Person person = new Person();
                //person.Age = 3;
                //Console.WriteLine(person.Age);
                //ChangeObjectByAge(person);
                //Console.WriteLine(person.Age);
                ////------------------------------------------------
                ////Dictionary<int, string> dic = new Dictionary<int, string>();
                ////dic.Add(1, "yarin");
                ////dic.Add(2, "sdf");
                ////dic.Remove(1);// remove by key

                ////Console.WriteLine(dic[1]);


                //////foreach (var item in dic)
                //////{
                //////    Console.WriteLine(item);
                //////}




                ////List<int> listInt = new List<int>();
                ////listInt.Add(1);
                ////listInt.Add(2);
                ////listInt.Add(3);

                ////List<string> listString = new List<string>();
                ////listString.Add("sdf");
                ////listString.Add("yarin");
                ////listString.Add("aa");
                ////listString[0] = "yarin";
                ////listString[1] = "yy";

                ////listString.RemoveAt(0);// remove by index
                ////listString.Remove("aa");// remove by item
                ////foreach (var item in listString)
                ////{
                ////    Console.WriteLine(item);
                ////}


                ////// list int
                //////listInt[0] = 33;

                ////// foreach (var item in listInt)
                ////// {
                //////     Console.WriteLine(item);
                ////// }

            }
            catch (Exception ex)
            {

                Console.WriteLine("error!");
            }

         
        }
    }

    class Person
    {
        public int Age { get; set; }
    }
}