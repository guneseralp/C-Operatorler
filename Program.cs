namespace OPERATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATAMA VE İŞLEMLİ ATAMA
            int x = 3;
            int y = 3;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("*************Mantiksal Operatorler******************");
            // Mantıksal Operatörler
            // ||,&&,!

            bool isSucces = true;
            bool isCompleted = false;
            if(isSucces && isCompleted)
                Console.WriteLine("Perfect");
            if(isSucces || isCompleted)
                Console.WriteLine("Great!");
            if(isSucces &&  !isCompleted)
                Console.WriteLine("Fine!");
            
            Console.WriteLine("*************Iliskisel Operatorler***************");
            // İlişkisel Operatörler
            //<,>,<=, >=,==,!=

            int a = 3;
            int b = 4;
            bool  sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc );
            sonuc= a >= b ;
            Console.WriteLine(sonuc );
            sonuc = a <= b ;
            Console.WriteLine(sonuc );
            sonuc = a == b  ;
            Console.WriteLine(sonuc );
            sonuc = a != b  ;
            Console.WriteLine(sonuc );

            Console.WriteLine("********Aritmektik Operatorler*********");
            //+,-,*,/
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 +sayi2;
            Console.WriteLine(sonuc1);
            sayi1 +=1;
            Console.WriteLine(sayi1);

            // % mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}