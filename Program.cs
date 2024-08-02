using System.Collections;
namespace Daspro_4;
// Harus di command dahulu baru bisa fungsi salah satu nya,maaf pak atas ketidaksesuaian yg bapak mau
class Program
{
    static void Main()
    {
        // Array
        string[] namaMahasiswwa = new string[5];
        Console.WriteLine("Array:");
        namaMahasiswwa[0]="Aqul";
        namaMahasiswwa[1]="Hans";
        namaMahasiswwa[2]="Syachrul";
        namaMahasiswwa[3]="Sohibal";
        namaMahasiswwa[4]="Abid";
        for (int i=0;i<namaMahasiswwa.Length;i++){
            Console.WriteLine("Nama Mahasiswa : "+namaMahasiswwa[i]);
        }
        Console.WriteLine("------------------------------");
        Console.WriteLine("ArrayList : ");

            // Arraylist
        ArrayList namaMahasiswwaList = new ArrayList();
        namaMahasiswwaList.Add("Aqul");
        namaMahasiswwaList.Add("Hans");
        namaMahasiswwaList.Add("Syachrul");
        namaMahasiswwaList.Add("Sohibal");
        namaMahasiswwaList.Add("Abid");
        
        foreach (string namaMahasiswwaa in namaMahasiswwaList)
        {
            Console.WriteLine("Nama Mahasiswa : "+namaMahasiswwaa);
        }

        // Mahasiswa Keluar
        for (int i = 0 ;i<3;i++)
        {
            namaMahasiswwaList.RemoveAt(i);
        }
        Console.WriteLine("-------------------");
        Console.WriteLine("3 Mahasiswa keluar");
        foreach (string update in namaMahasiswwaList)
        {
            Console.WriteLine("Nama Mahasiswa: " + update);
        }
        // Maba
        string[] mahasiswaBaru = {"Richard","Arif","Gideon"};

        foreach (string list in mahasiswaBaru)
        {
            namaMahasiswwaList.Add(list);
        }
        Console.WriteLine("--------------------");
        Console.WriteLine("3 Mahasiswa Baru");
        foreach (string update in namaMahasiswwaList)
        {
            Console.WriteLine("Nama Mahasiswa: " + update);
        }

    }
    }


