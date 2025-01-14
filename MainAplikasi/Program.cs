// See https://aka.ms/new-console-template for more information
using MainAplikasi;

Console.WriteLine("Hello, World!");

BackgroundWork.StartBackgroundWork();

ObserverOnDemand observerOnDemand = new ObserverOnDemand();
observerOnDemand.DoLongRunningOperation("Iki loh mulai");

CombineLatest combineLatest = new CombineLatest();
combineLatest.ParallelExecutionTest();

DisposableScheduler scheduler = new DisposableScheduler();
IDisposable subscription = scheduler.CreateObservable().Subscribe(i => Console.WriteLine(i));
Console.WriteLine("Press any key to cancel");
Console.ReadKey();
subscription.Dispose();
Console.WriteLine("Press any key to quit");
Console.ReadKey();  // give background thread chance to write the cancel acknowledge message