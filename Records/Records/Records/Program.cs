// See https://ka.ms/new-console-template for more information

//MyClass m1 = new MyClass()
//{
//    MyProperty1 = 5
//};
//MyRecord m3 = new MyRecord()
//{
//    MyProperty1 = 5
//};



//MyClass m2 = new MyClass()
//{
//    MyProperty1 = 5
//};
//MyRecord m4 = new MyRecord() { MyProperty1 = 5 };

//Console.WriteLine(m1.Equals(m2));
//Console.WriteLine(m3.Equals(m4));

//MyClass m = new MyClass()
//{
//    MyProperty1 = 5,
//    MyProperty2 = 10
//};

//m.MyProperty2 = 15;

//MyClass m2 = new MyClass()
//{
//    MyProperty1 = m.MyProperty1,
//    MyProperty2 = 15
//};

//MyClass m2 = m.With(15);

MyRecord m = new MyRecord()
{
    MyProperty1 = 5,
    MyProperty2 = 10
};

MyRecord m2 = m with { MyProperty2 = 15 };
public record MyRecord
{
    public int MyProperty1 { get; init; } // Bu şekilde tanımlanan record'lara Norminal Records denir.
    public int MyProperty2 { get; init; }

}

class MyClass
{
    public int MyProperty1 { get; init; }
    public int MyProperty2 { get; init; }

    public MyClass With(int property2)
    {
        return new MyClass
        {
            MyProperty1 = this.MyProperty1,
            MyProperty2 = property2
        };
    }
}