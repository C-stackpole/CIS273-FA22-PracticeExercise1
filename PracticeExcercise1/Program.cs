namespace PracticeExercise1;

class Program
{
    static void Main(string[] args)
    {

        ArrayList arrayList = new ArrayList();
        //Prepend and Append Works
        arrayList.Prepend(8);
        arrayList.Prepend(4);
        arrayList.Prepend(2);
        arrayList.Prepend(1);
        arrayList.Prepend(9);
        arrayList.Prepend(8);
        arrayList.Append(7);
        Console.WriteLine(arrayList);

        //Console.WriteLine(arrayList.Contains(8));
        //Console.WriteLine(arrayList.Contains(100)); Contain Works 

        //Console.WriteLine(arrayList.FirstIndexOf(1));
        //Console.WriteLine(arrayList.FirstIndexOf(100)); FirstIndexOf Works

        //arrayList.InsertAfter(1,8);
        //Console.WriteLine(arrayList);
        //arrayList.InsertAfter(1,100);
        //Console.WriteLine(arrayList); InsertAfter Works

        //arrayList.InsertAt(1, 0);
        //Console.WriteLine(arrayList);
        //arrayList.InsertAt(1, 100);
        //Console.WriteLine(arrayList); InsertAt Works

        //arrayList.Remove(7);
        //Console.WriteLine(arrayList);
        //arrayList.RemoveAt(0);
        //Console.WriteLine(arrayList); Remove and RemoveAt Works

        //Console.WriteLine(arrayList.Get(2)); Get Works

        Console.WriteLine(arrayList.Reverse()); //Reverse Works

        Console.ReadKey();
    }
}

