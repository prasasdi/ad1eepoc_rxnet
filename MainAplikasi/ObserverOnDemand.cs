using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAplikasi
{
    /// <summary>
    /// To understand how to create an on demand operation by subscribing an Observable 
    /// </summary>
    public class ObserverOnDemand
    {
        /*
         * Execute a long-running method asynchronously. 
         * The method does not start running until there is a subscriber. 
         * 
         * The method is started every time the observable is created and subscribed, 
         * so there could be more than one running at once.
         */
        string _param;
        public ObserverOnDemand() { }

        public DataType DoLongRunningOperation(string param)
        {
            Console.WriteLine($"Doing some long operation with param: {param}");
            this._param = param;
            return DataType.Text;
        }

        public IObservable<DataType> LongRunningOperationAsync(string param)
        {
            return Observable.Create<DataType>(
                o => Observable.ToAsync<string, DataType>(DoLongRunningOperation)(param).Subscribe(o)
            );
        }
    }
}
