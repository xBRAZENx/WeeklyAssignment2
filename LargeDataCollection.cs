using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAssignment2
{
    public class LargeDataCollection : IDisposable
    {
        public List<string> list= new List<string>();
        bool disposedValue;int listCount;
        public LargeDataCollection()
        {
            Console.WriteLine("Enter number of items to be added to List");
            listCount = int.Parse(Console.ReadLine());
            for(int i = 0; i < listCount; i++)
            {
                
                list.Add(Console.ReadLine());
            }
        }
        public void Add(string item) { list.Add(item);listCount++; }
        public void Remove(string item) { list.Remove(item);}
        public void AccessData(int index)
        {
            Console.WriteLine(list.ElementAt(index));
        }
        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                   listCount = 0;
                }
                list = null; disposedValue = true;
                Console.WriteLine("List has been nullified");
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
