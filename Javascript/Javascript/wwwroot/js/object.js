window.onload = () => {
    //Objects (Nesneler)

    //const: sabi anlamında kullanılır. herhangi bir değişken tarafında kullanılan "sabit" olarak tnaımlamış oluruz. değeri değiştiremeyiz.

    GetCartTotalPrice();

}





const object = [
    {
        name: "fatih",
        lastname: "günalp",
        addresses: {
            homeAddress: {
                name: "ev adresi",
                address: "Ataşehir"
            },
            workAddress: {
                name: "iş adresi",
                address: "Kadıköy"
            }
        }
    },
    {
        name: "andrew",
        lastname: "fuller",
        addresses: {
            homeAddress: {
                name: "ev adresi",
                address: "Seattle"
            },
            workAddress: {
                name: "iş adresi",
                address: "New York"
            }
        }
    }
]

//console.log(object);
//console.log(object.addresses)
//console.log(object.name)

//Bir market içerisinde satışı gerçekleştirilecek ürünleri nesne olarak oluşturun.



//ürünleri barındıracak olan array
const sepet = [];

//Ekmek
const ekmek = {
    name: "kepekli ekmek",
    price: 30
}

//Çikolata
const cikolata = {
    name: "tadelle",
    price: 25
}

//Makarna
const makarna = {
    name: "Barilla",
    price: 50
}


//Peynir.
const peynir = {
    name: "beyaz peynir",
    price: 200
}

//yukarıda tanımlı olan ürünlerden istediklerimizi sepet'in içerisine dahil ediyoruz.
sepet.push(ekmek);
sepet.push(cikolata);

//For ya da forEach döngülerini kullanarak sepet içerisinde bulunan ürünlerin detaylarını console'da gösteriyoruz.
//for (let i = 0; i < sepet.length; i++) {
//    console.log(sepet[i].name)
//}

//sepet.forEach(function (v,i) {
//    console.log(i+" "+v.name);
//})

//sepet.forEach((v,i) => {
//    console.log(i + " " + v.name);
//})

//Sepet içindeki ürünlerin toplam bilgisini console'da gösteren fonksiyon.

function GetCartTotalPrice() {

    let totalPrice = 0;

    for (let i = 0; i < sepet.length; i++) {
        totalPrice += sepet[i].price;
    }
    console.log("Sepetinizin toplam tutarı: " + totalPrice + "TL")
}