// See https://aka.ms/new-console-template for more information
using MainAplikasi;

Console.WriteLine("Hello, World!");

BackgroundWork.StartBackgroundWork();

ObserverOnDemand observerOnDemand = new ObserverOnDemand();
observerOnDemand.DoLongRunningOperation("Iki loh mulai");
