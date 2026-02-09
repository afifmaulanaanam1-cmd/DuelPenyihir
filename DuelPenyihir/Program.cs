
Wizard wizardA = new Wizard("Sulis", 30);
Wizard wizardB = new Wizard("Yinarti", 10);

Console.WriteLine("Permainan Dimulai.....\n");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Attack(wizardB);

string pilihan;

while (wizardA.Energi > 0 && wizardB.Energi > 0)
{

    Console.WriteLine($"1. {wizardA.Nama} Menyerang {wizardB.Nama}");
    Console.WriteLine($"2. {wizardB.Nama} Menyerang {wizardA.Nama}");
    Console.WriteLine($"3. {wizardA.Nama} Melakukan Heal");
    Console.WriteLine($"4. {wizardB.Nama} Melakukan Heal");

    Console.Write("\nMasukkan pilihanmu (1/2/3/4) : ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan Tidak Valid!");
    }
}

Console.WriteLine("Permainan Berakhir....!\n");
wizardA.ShowStats();
wizardB.ShowStats();

if (wizardB.Energi < wizardA.Energi)
{
    Console.WriteLine($"{wizardA.Nama} memenangkan pertandingan");
}
else
{
    Console.WriteLine($"{wizardB.Nama} memenangkan pertandingan");
}


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
        Energi = 50;
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