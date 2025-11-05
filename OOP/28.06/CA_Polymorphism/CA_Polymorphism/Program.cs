/*
 Nesne yönelimli programlama'da kullanılan 4 adet prensip bulunmaktadır.
    1-Encapsulation=> Kapsulleme
    2-Inheritance=> Kalıtım miras
    3-Polymorphism=> Çok biçimlilik



3 adet hayvan oluşturun. 
    //Kedi => nesne
        Ad=> tekir
        SesCikar()
    //Köpek => nesne
        SesCikar()
    //Kuş => nesne
        SesCikar()

daha sonra bu oluşturulan nesnelerden ayrı ayrı instance alınsın.
//Alınan instance eğer kedi ise console'da "miyavvvv"
//Alınan instance eğer köpek ise console'da "hav hav"
//Alınan instance eğer kuş ise console'da "cik cik"

yazısını gösterin.

 */

using CA_Polymorphism;

Kedi kedi=new Kedi();


kedi.SesCikar();

Kopek kopek = new Kopek();
kopek.SesCikar();

Kus kus = new Kus();
kus.SesCikar();

Yarasa yarasa= new Yarasa();
yarasa.SesCikar();
//
