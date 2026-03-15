namespace TP_modul4_103022400121
{
    public class KodePos
    {
        private Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            {"Batununggal", "40266"}, {"Kujangsari", "40287"}, {"Mengger", "40267"},
            {"Wates", "40256"}, {"Cijaura", "40287"}, {"Jatisari", "40286"},
            {"Margasari", "40286"}, {"Sekejati", "40286"}, {"Kebonwaru", "40272"},
            {"Maleer", "40274"}
        };

        public string getKodePos(string kelurahan)
        {
            return dic.ContainsKey(kelurahan) ? dic[kelurahan] : "Tidak ditemukan";
        }
    }

    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka };
        public State currentState = State.Terkunci;

        public void PerubahanState(string command)
        {
            if (currentState == State.Terkunci && command == "BukaPintu")
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else if (currentState == State.Terbuka && command == "KunciPintu")
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            KodePos kp = new KodePos();
            string[] contohKelurahan = { "Batununggal", "Wates", "AsalSebut" };

            Console.WriteLine("--- Testing Table-Driven ---");
            foreach (var kel in contohKelurahan)
            {
                Console.WriteLine($"Input: {kel} | Output: {kp.getKodePos(kel)}");
            }

            Console.WriteLine("\n--- Testing State-Based ---");
            DoorMachine pintu = new DoorMachine();
            pintu.PerubahanState("BukaPintu");  
            pintu.PerubahanState("KunciPintu"); 

            Console.WriteLine("class main d atas saya pakai hanya untuk testing logika dari kedua class");
        }
    }
}

