using TP_MODUL5_103022400002;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Stefhanie Valentina");

        DataGeneric<string> data = new DataGeneric<string>("103022400002_Stefhanie Valentina");
        data.PrintData();

    }
}