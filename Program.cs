using System;
using System.Collections;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            
         ArrayList arraylist = new ArrayList();
          arraylist.Add(new Staff(1,"Nam",24));
          arraylist.Add(new Staff(2, "Kien", 21));
           arraylist.Add(new Staff(3, "Viet", 21));
          arraylist.Add(new Staff(4, "Hang", 23));
           arraylist.Add(new Staff(5, "Tien", 24));
           System.Console.WriteLine("ID , nhan vien , tuoi ");
           var nhat = arraylist.OfType<Staff>();
            var arrayList1 = from n in nhat
                         where (n.Age < 24)
                         select n;
            var sapxep = from a in nhat
                         where (a.Age < 24)
                         orderby a.Name
                         select a;

            foreach (var item in arrayList1)
            {
                Console.WriteLine("ID :" + item.ID + " Name : " + item.Name + " Age : " + item.Age);
            }
             Console.WriteLine("Sap xep theo ten :");
            foreach (var item in sapxep)
            {
                Console.WriteLine("ID :" + item.ID + " Name : " + item.Name + " Age : " + item.Age);
            }
        }
    }
}
