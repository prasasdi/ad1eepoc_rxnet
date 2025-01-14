using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAplikasi
{
    /// <summary>
    /// To learn Parallel execution in Observable
    /// </summary>
    public class CombineLatest
    {
        /*
         * Merges the specified observable sequences into one observable sequence by emitting a list with the latest source elements whenever any of the observable sequences produces an element.
         */
        public CombineLatest()
        {
            
        }

        public async void ParallelExecutionTest()
        {
            var o = Observable.CombineLatest(
                Observable.Start(() => { Console.WriteLine("Executing 1st on Thread: {0}", Thread.CurrentThread.ManagedThreadId); return "Result A"; }),
                Observable.Start(() => { Console.WriteLine("Executing 2nd on Thread: {0}", Thread.CurrentThread.ManagedThreadId); return "Result B"; }),
                Observable.Start(() => { Console.WriteLine("Executing 3rd on Thread: {0}", Thread.CurrentThread.ManagedThreadId); return "Result C"; })
            ).Finally(() => Console.WriteLine("Done!"));

            foreach (string r in await o.FirstAsync())
                Console.WriteLine(r);
        }
    }
}
