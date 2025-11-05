

namespace CA_Class //class'ların ait olduğu proje namespace olarak tanımlanmalıdır.
{
    class Bilgisayar
    {
        //Bir bilgisayarın ....'sı olur.
        //islemci
        //ram
        //grafik kart
        //ana kart
        //
        

        //Erişim Belirleyiciler. (Access Modifiers)
        /*
            private: bir field (alan) private olarak tanımlanırsa sadece bağlı bulunduğu class içerisinden ulaşılır. Eğer bir field başlangıcında herhangi bir belirteç girilmemiş ise varsayılan olarak o field "private" dır.
            public: umumi/açık heryerden ulaşılabilinir anlamına gelir.
            internal: (dahil) sadece bağlı bulunduğu projeden ulaşılır.
        /////////////////////////////
            protected: miras verilen class içerisinden ulaşılır.
            protected internal: aynı projeden fakat mrias verilen class'dan ulaşılır.

            
         */

        //değişken
       public string islemci;//marka model alır.
       public string ramKapasite;//kapasite alır.
       public string grafikKart;//marka model.
       public string anakart;//marka model
    }
}