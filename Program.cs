using System;
using System.Collections.Generic;
class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara.";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun, Jumlah Kaki: {JumlahKaki}";
    }
}

class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun, Panjang Tubuh: {PanjangTubuh} meter";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Singa ini mengaum";
    }

    public string Mengaum()
    {
        return $"{Nama} sedang mengaum";
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Gajah ini menderu";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Ular ini mendesis";
    }

    public string Merayap()
    {
        return $"{Nama} sedang merayap";
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Buaya ini menggeram";
    }
}


class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        if (koleksiHewan.Count == 0)
        {
            Console.WriteLine("Tidak ada hewan di kebun binatang.");
        }
        else
        {
            Console.WriteLine("Daftar Hewan di Kebun Binatang:");
            foreach (var hewan in koleksiHewan)
            {
                Console.WriteLine(hewan.InfoHewan());
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Singa Asia", 5);
        Gajah gajah = new Gajah("Gajah Borneo", 10);
        Ular ular = new Ular("Ular Python", 3, 2.5);
        Buaya buaya = new Buaya("Buaya Muara", 7, 3.0);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nSuara Hewan di Kebun Binatang:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\nMethod Khusus:");
        Console.WriteLine(singa.Mengaum());
        Console.WriteLine(ular.Merayap());
    }
}
