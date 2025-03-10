public enum StudentState {TERDAFTAR, CUTI, AKTIF, LULUS}
public enum Trigger {MENGAJUKAN_CUTI, MENYELESAIKAN_CUTI, CETAK_KSM, YUDISIUM}

public class Transition
{
    public StudentState stateAwal;
    public StudentState stateAkhir;
    public Trigger trigger;

    public Transition(StudentState stateAwal, StudentState stateAkhir, Trigger trigger)
    {
        this.stateAwal = stateAwal;
        this.stateAkhir = stateAkhir;
        this.trigger = trigger;
    }
}
public class Mahasiswa()
{

    public StudentState currentState = StudentState.TERDAFTAR;

    Transition transisi = new Transition(StudentState.TERDAFTAR, StudentState.CUTI, Trigger.MENGAJUKAN_CUTI);
    public StudentState getNextState(StudentState stateAwal, Trigger trigger)
    {
        StudentState stateAkhir = stateAwal;

        if (stateAwal == transisi.stateAwal && trigger == transisi.trigger)
        {
            stateAkhir = transisi.stateAkhir;
        }

        return stateAkhir;
    }

    public void activeTrigger(Trigger trigger)
    {
        currentState = getNextState(currentState, trigger);

        Console.WriteLine($"State anda saat ini {currentState}");

        if (currentState == StudentState.CUTI)
        {
            Console.WriteLine("Pengajuan cuti akan kami informasikan 1x24 jam");
        }
    }
}

public class Program()
{
    public static void Main(string[] args)
    {

        Mahasiswa objMhs = new Mahasiswa();
        objMhs.activeTrigger(Trigger.MENGAJUKAN_CUTI);

    }
}