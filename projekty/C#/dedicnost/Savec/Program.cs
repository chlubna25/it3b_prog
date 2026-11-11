using System;

class Program
{
    static void Main()
    {
        Ptakopysk ptakopysk = new Ptakopysk("Piko");
        Savec[] savci = { new Pes("Rex"), ptakopysk };

        foreach (Savec savec in savci)
        {
            savec.PredstavSe();
            // POLYMORFISMUS: volání stejné metody vybere implementaci podle skutečného typu.
            savec.VydatZvuk();
        }

        ptakopysk.SnesVajicko();
    }
}