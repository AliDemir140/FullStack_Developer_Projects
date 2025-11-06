


//function.html içerisinde bulunan elementleri öncelikle değişkenler içerisine alıyoruz.


//function:
//fonksyion içerisinde eğer geriye değer dönüşü olacaksa sadece "return" anahtar kelimesini kullanmamız yeterlidir.

//Elementlere ulaşım
//Buttons
var btn1 = document.getElementById("btn1");
var btn2 = document.getElementById("btn2");
var btn3 = document.getElementById("btn3");
var btn4 = document.getElementById("btn4");
var btnShow = document.getElementById("btnShow");
var btnProductDetail = document.getElementById("btnProductDetail");

//Inputs
var input1 = document.getElementById("input1");



//Headers
var header1 = document.getElementById("header1");
var header2 = document.getElementById("header2");
var header3 = document.getElementById("header3");
var header4 = document.getElementById("header4");





//Eylemler
function Fonksiyon1() {
    alert("fonksiyon 1 çalıştı")
}

function Fonksiyon2() {
    return "fonksiyon 2 çalıştı"
}

function Fonksiyon3(deger) {
    header3.innerText = deger;
}

function Fonksiyon4(sayi1,sayi2) {
    return sayi1 + sayi2;
}



//Element ve Fonksiyon Kullanımları
//Ne zaman ve Ne?

//btn1 tıklandığında Fonksyion1() isimli eylem çalışsın.
btn1.onclick = function () {
    Fonksiyon1();
}

//btn2 tıklandığında header2'nin içeriği değiştirilsin.
btn2.onclick = function () {
    header2.innerText = Fonksiyon2();
}

//btnShow tıklandığında id'si popUp olan div gösterilecek.
btnShow.onclick = function () {
    var popUpDiv = document.getElementById("popUp");
    popUpDiv.style = "display:block";
}

//btn3 tıklandığında id'si input1 olan girdinin değerini id'si header3 olan element içerisinde gösterilecek.
btn3.onclick = function () {
    var value = input1.value;
    Fonksiyon3(value);
}

//btn4 tıklandığında sayı1'in değeri ve sayı2'nin değeri toplanacak, toplam sonuc header4 içine yazdırılacak.
btn4.onclick = function () {
    //bütün input'lar değerlerini string olarak teslim ederler.


    var input2 = document.getElementById("input2");

    var input3 = document.getElementById("input3");
  
    //Tip Dönüşümü
    var sayi1 = parseInt(input2.value);
    var sayi2 = parseInt(input3.value);


   var toplam = Fonksiyon4(sayi1,sayi2);
   

    header4.innerText = toplam;
}

//btnProductDetail tıklandığında ProductDetail.html sayfasına yönlendirme yapılacak.

//btnProductDetail.onclick = function () {
//    location.href="/productDetail.html"
//}

btnProductDetail.onclick = ()=>{
    location.href = "/productDetail.html"
}