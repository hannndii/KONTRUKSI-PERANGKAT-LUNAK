using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();
        string[] kelurahan = {
            "Batununggal", "A. Kujangsari", "Mengger", "Wates",
            "Cijaura", "Jatisari", "Margasari", "Sekejati",
            "Kebonwaru", "Maleer", "Samoja"
        };

        Console.WriteLine("\n = = = = = = = = = = = = = = = = = = = = = = = = = \n");
        Console.WriteLine("\t\t Tabel Driven \t\t");
        Console.WriteLine("\n = = = = = = = = = = = = = = = = = = = = = = = = = \n");

        foreach (string k in kelurahan)
        {
            Console.WriteLine($"{k.PadRight(15)}: {kodePos.GetKodePos(k)}");
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

public class KodePos
{
    private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>();

    public KodePos()
    {
        tabelKodePos.Add("Batununggal", "40266");
        tabelKodePos.Add("A. Kujangsari", "40287");
        tabelKodePos.Add("Mengger", "40267");
        tabelKodePos.Add("Wates", "40256");
        tabelKodePos.Add("Cijaura", "40287");
        tabelKodePos.Add("Jatisari", "40286");
        tabelKodePos.Add("Margasari", "40286");
        tabelKodePos.Add("Sekejati", "40286");
        tabelKodePos.Add("Kebonwaru", "40272");
        tabelKodePos.Add("Maleer", "40274");
        tabelKodePos.Add("Samoja", "40273");
    }

    public string GetKodePos(string kelurahan)
    {
        return tabelKodePos.ContainsKey(kelurahan) ?
            tabelKodePos[kelurahan] :
            "Kode pos tidak ditemukan";
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
                if (action.ToLower() == "Buka")
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