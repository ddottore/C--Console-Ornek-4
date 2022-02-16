int sayi, i , x , carpim = 1 , toplam = 0;
Console.Write("Faktöriyel Toplamın yapılacağı sayıyı giriniz : ");
sayi = Convert.ToInt32(Console.ReadLine());

for (x=1; x <= sayi;x++) 
{
 
    for (i = x; i <= x; i++)
    {
        carpim *= i;
    }

    toplam += carpim;
}

Console.WriteLine("Cevap : " + toplam);



//Faktöriyel sayıların faktöriyel biçimde toplanması, örn: 5 sayısı >> 5! + 4! + 3! + 2! + 1!