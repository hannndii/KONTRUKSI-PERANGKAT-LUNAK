using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n = = = = = = = = = = = = = = = = = = = = = = = = = \n");
        Console.WriteLine("\t\t Tabel Driven \t\t");
        Console.WriteLine("\n = = = = = = = = = = = = = = = = = = = = = = = = = \n");

        string[] kelurahan = {
            "Batununggal", "Kujangsari", "Mengger", "Wates",
            "Cijaura", "Jatisari", "Margasari", "Sekejati",
            "Kebonwaru", "Maleer", "Samoja"
        };

        foreach (string k in kelurahan)
        {
            Console.WriteLine($"{k.PadRight(15)}: {KodePosHelper.GetKodePos(k)}");
        }

        Console.WriteLine("\n = = = = = = = = = = = = = = = = = = = = = = = = = \n");
        Console.WriteLine("\t\t State-Based Construction \t\t");
        Console.WriteLine("\n = = = = = = = = = = = = = = = = = = = = = = = = = \n");

        DoorMachine door = new DoorMachine();
        door.TriggerState("buka");
        door.TriggerState("kunci");
        door.TriggerState("buka");
        door.TriggerState("buka");
    }
}

public enum KodePos
{
    Batununggal = 40266,
    Kujangsari = 40287,
    Mengger = 40267,
    Wates = 40256,
    Cijaura = 40287,
    Jatisari = 40286,
    Margasari = 40286,
    Sekejati = 40286,
    Kebonwaru = 40272,
    Maleer = 40274,
    Samoja = 40273
}

public class KodePosHelper
{
    public static int GetKodePos(string kelurahan)
    {
        return Enum.TryParse(kelurahan, out KodePos kode) ? (int)kode : -1;
    }
}

public class DoorMachine
{
    public enum State
    {
        Terkunci,
        Terbuka
    }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void TriggerState(string action)
    {
        switch (currentState)
        {
            case State.Terkunci:
                if (action.ToLower() == "buka")
                {
                    currentState = State.Terbuka;
                    Console.WriteLine("Pintu tidak terkunci");
                }
                else
                {
                    Console.WriteLine("Aksi tidak valid (dalam keadaan terkunci)");
                }
                break;

            case State.Terbuka:
                if (action.ToLower() == "kunci")
                {
                    currentState = State.Terkunci;
                    Console.WriteLine("Pintu terkunci");
                }
                else
                {
                    Console.WriteLine("Aksi tidak valid (dalam keadaan terbuka)");
                }
                break;
        }
    }
}