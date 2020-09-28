using System;
namespace Linq
{
    internal class Staff
    {
     
        public int ID{get;set;}
           public string Name{get;set;}
        public int Age{get;set;}
public Staff(int Id,string Name,int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
      
    }
}