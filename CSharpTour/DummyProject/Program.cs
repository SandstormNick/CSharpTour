using acmeCol = Acme.Collections;

//var s = new Acme.Collections.Stack<int>();
var s = new acmeCol.Stack<int>();
s.Push(1); // stack contains 1
s.Push(10); // stack contains 1, 10
s.Push(100); // stack contains 1, 10, 100
Console.WriteLine(s.Pop()); // stack contains 1, 10
Console.WriteLine(s.Pop()); // stack contains 1
Console.WriteLine(s.Pop()); // stack is empty


string s1 = "Hello World";

Console.WriteLine(s1);

//An identifier is a variable name.
//An identifier may be a C# reserved word, if it's prefixed by @.
//Using a reserved word as an identifier can be useful when interacting with other languages.
string @string = "string is a reserved word in c#";

Console.WriteLine(@string);

//In the following example, an int value is converted to object and back again to int.
int i = 123;
object o = i;    // Boxing
int j = (int)o;  // Unboxing
Console.WriteLine(j);

//this boxing/unboxing would break the program though
string s2 = "string";
object o2 = s2;
int r = (int)o2;
Console.WriteLine(r);


class IAmAClass : IAmAnInterface
{
    public void IAmAMethod()
    {
        throw new NotImplementedException();
    }
}

struct IAmAStruct : IAmAnInterface
{
    public void IAmAMethod()
    {
        throw new NotImplementedException();
    }
}

interface IAmAnInterface
{
    public void IAmAMethod();
}
