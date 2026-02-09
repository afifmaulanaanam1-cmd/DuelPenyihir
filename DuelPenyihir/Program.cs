
Wizard wizardA = new Wizard("Sulis", 30);
Wizard wizardB = new Wizard("Yinarti", 10);

Console.WriteLine("Permainan Dimulai.....\n");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan Berakhir....!\n");
wizardA.ShowStats();
wizardB.ShowStats();


public class Wizard
{
    //deklarasi field 
    public string Nama;
    public int Energi;
    public int Damage;

    //deklarasi constructor
    public Wizard (string nama, int damage)
    {
        Nama = nama;
        Energi = 100;
        Damage = damage;
    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard ");
        Console.WriteLine($"Nama : {Nama}, Energi : {Energi} \n");
    }

    public void Attack(Wizard wizardlawanOBJ)
    {
        //mengurangi energi wizardlawanOBJ sebesar damage
        wizardlawanOBJ.Energi -= Damage;
        Console.WriteLine($"{Nama} menyerang {wizardlawanOBJ.Nama}");
        Console.WriteLine($"Sisa energi {wizardlawanOBJ.Nama} adalah {wizardlawanOBJ.Energi}\n");
    }

    public void Heal()
    {
        Energi += 5;
        if (Energi < 100)
        {

            Console.WriteLine($"{Nama} melakukan heal! Energi meningkat menjadi {Energi}");

        }
        else
        {
            Energi = 100; 
           Console.WriteLine("Sudah mencapai energi maksimum");
            
        }
    }
}