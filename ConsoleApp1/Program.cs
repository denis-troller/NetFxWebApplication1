// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SpinLock sl = new SpinLock();
int j;

int a = j + 1;

bool taken = false;

sl.Enter(ref taken);