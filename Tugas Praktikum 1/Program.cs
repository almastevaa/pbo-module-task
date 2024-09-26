using System;
using System.Collections.Generic;

class Hewan
{
    public string nama;
    public int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {nama}, Umur: {umur} tahun";
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {jumlahKaki}";
    }
}

class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {panjangTubuh} meter";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Rawrrrr!";
    }

    public string Mengaum()
    {
        return "Singa mengaum dengan keras!";
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Trumphh!";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Ssssss!";
    }

    public string Merayap()
    {
        return "Ular merayap di lantai dengan lincah!";
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "kiw cewe!";
    }
}

class KebunBinatang
{
    private List<Hewan> koleksiHewan;

    public KebunBinatang()
    {
        koleksiHewan = new List<Hewan>();
    }

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Singa Arema", 5);
        Gajah gajah = new Gajah("Gajah Mada", 10);
        Ular ular = new Ular("Ular Kadut", 3, 7.1);
        Buaya buaya = new Buaya("Buaya Darat", 8, 4.5);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nSuara Hewan:");
        Console.WriteLine($"Singa: {singa.Suara()}");
        Console.WriteLine($"Gajah: {gajah.Suara()}");
        Console.WriteLine($"Ular: {ular.Suara()}");
        Console.WriteLine($"Buaya: {buaya.Suara()}");

        Console.WriteLine("\nMethod Khusus:");
        Console.WriteLine($"Singa mengaum: {singa.Mengaum()}");
        Console.WriteLine($"Ular merayap: {ular.Merayap()}");
    }
}