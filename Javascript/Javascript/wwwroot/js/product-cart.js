window.onload = () => {

    //sayfa hazır olduğunda id'si product-row olan div'e ualaşarak içerisine products isimli nesnenin özelliklerinin dahil edilmesi.

   

   /* product_row.innerHTML = "<div class='col-md-3'><div class='card'><div class='card-body'><h3>Product Name</h3><h4>18₺</h4></div> <div class='card-footer text-center'><button class='btn btn-primary'>Add To Cart</button></div></div ></div>"*/

   //Backtick `` AltGr+,
    //product_row.innerHTML = `
    //                <div class="col-md-3">
    //                    <div class="card">
    //                        <div class="card-body">
    //                            <h3>Product Name</h3>
    //                            <h4>18₺</h4>
    //                        </div>
    //                        <div class="card-footer text-center">
    //                            <button class="btn btn-primary">Add To Cart</button>
    //                        </div>
    //                    </div>
    //                </div>
    //`

    ProductListFunction();
    GetCartList();
    
}

//Elements
const product_row = document.getElementById("product-row");

//Array
const sepet = [];

//products object
const products = [
    { productName: "chai", unitPrice: 15, count: 0 },
    { productName: "chang", unitPrice: 18, count: 0 },
    { productName: "ikura", unitPrice: 20, count: 0 },
    { productName: "tofu", unitPrice: 25, count: 0 },
    { productName: "örnek ürün 1", unitPrice: 25, count: 0 },
    { productName: "örnek ürün 2", unitPrice: 25, count: 0 },
]

//ProductListFunction
function ProductListFunction() {
    products.forEach((v, i) => {
        product_row.innerHTML += `
                    <div class="col-md-3">
                        <div class="card">
                            <div class="card-body">
                                <h3>${v.productName}</h3>
                                <h4>${v.unitPrice}₺</h4>
                            </div>
                            <div class="card-footer text-center">
                                <button onclick="AddToCart('${v.productName}','${v.unitPrice}')" class="btn btn-primary">Add To Cart</button>
                            </div>
                        </div>
                    </div>
    `
    })
}


//AddToCart
function AddToCart(urunAd, urunFiyat) {
    //parametreden gelen bilgileri bir nesne içerisinde oluşturarak sepet'e eklenecek.
    const productItem = { productName: urunAd, unitPrice: urunFiyat };
    sepet.push(productItem)
   
    GetCartList();
    
}


//GetCartList
function GetCartList() {

    var totalPrice = 0;
    
    const cart_body = document.getElementById("cart-body");
    cart_body.innerHTML = "";


    const ul = document.createElement("ul");
    const li = document.createElement("li");
    li.className = "list-group-item";

    if (sepet.length == 0) {
        li.innerHTML = "sepetinizde ürün bulunmamaktadır!"
        ul.append(li);
    } else {
        console.log(sepet);
        for (var i = 0; i < sepet.length; i++) {

            totalPrice += parseFloat(sepet[i].unitPrice);
            cart_body.innerHTML += `
           <ul class="list-group">
                            <li class="list-group-item">${sepet[i].productName} ${sepet[i].unitPrice
}                               </li>
                        </ul>
            `
            
        }
        //id'si totalPrice olan h4 içerisinde toplam tutar gösterilir.
        document.getElementById("totalPrice").innerHTML =`Toplam Tutar:${totalPrice}₺`
    }
    



    
}

