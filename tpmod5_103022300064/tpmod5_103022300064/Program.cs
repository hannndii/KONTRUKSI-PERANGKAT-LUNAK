using System;

class HaloGeneric
{
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}
class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric.SapaUser("Budi"); 

        DataGeneric<string> nimData = new DataGeneric<string>("103022300064"); 
        nimData.PrintData();
    }
}