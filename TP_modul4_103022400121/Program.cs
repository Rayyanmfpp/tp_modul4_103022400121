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
}

