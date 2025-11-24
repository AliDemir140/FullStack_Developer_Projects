window.onload = () => {
  GetProducts();
  productList.style = "display:none";
  var loadingH3 = document.createElement("h3");
  loadingH3.innerText = "Veriler yükleniyor...";
  let loading = document.getElementById("loading");

  loading.append(loadingH3);
};
///base api Url
const baseApiUrl = "https://localhost:7059";

//product Container
var productContainer = document.getElementById("productContainer");

var productList = document.getElementById("productList");

///functions
//ürünleri Api'dan çağıran fonksiyon
function GetProducts() {
  //WebApi projesine istekte bulunarak teslim edilen ürünleri tablo içerisinde listeyeceğiz.

  //fetch: dış kaynakta bulunan bir service istekte bulunmamıza olanak sağlar.

  fetch(baseApiUrl + "/api/product")
    .then((response) => response.json())
    .then((data) => {
      FillProduct(data);
    });
}

//Ürünleri tabloya ekleme fonksiyonu
function PostProduct() {
  let productName = document.getElementById("productName").value;
  let unitPrice = document.getElementById("unitPrice").value;
  let unitsInStock = document.getElementById("unitsInStock").value;

  console.log(
    "Ürün Ad: " +
      productName +
      " Ürün Fiyat: " +
      unitPrice +
      " stok: " +
      unitsInStock
  );

  //Jquery:
  //AJAX ()
  $.ajax({
    url: baseApiUrl + "/api/product",
    contentType:"application/json",
    type: "post",
    data: JSON.stringify({
      ProductName: productName,
      UnitPrice: unitPrice,
      UnitsInStock: unitsInStock,
    }),
    success:function(response){
        alert(response)
        GetProducts();
    },
    error:function(err){
        alert(err)
    }
  });
}

function FillProduct(data) {
    productList.innerHTML="";
  data.forEach((value, index) => {
    // console.log(value.productName+" "+index)

    let tr = `
                              <tr>
                                    <td>${value.id}</td>
                                    <td>${value.productName}</td>
                                    <td>${value.unitPrice}</td>
                                    <td>${value.unitsInStock}</td>
                                </tr>
        `;
    productList.innerHTML += tr;
  });

  productList.style = "display:contents";
  loading.style = "display:none";
}
