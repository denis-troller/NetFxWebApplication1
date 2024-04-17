// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SpinLock sl = new SpinLock();
int j;

int a = j + 1;

bool taken = false;

var c1 = new SharedProject1.SharedClass1();

c1.SharedMethod1();

sl.Enter(ref taken);