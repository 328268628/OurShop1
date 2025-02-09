﻿addEventListener("load", () => {
    let user = sessionStorage.getItem("Id") || "-1"
    sessionStorage.setItem("user", user)
    DrawProducts()
})
const DrawProducts = () => {
    products = sessionStorage.getItem("shopingBag")
    products = JSON.parse(products)
    let totalPrice = 0;
    console.log(products.length);
    document.getElementById("itemCount").textContent = products.length; 
    document.querySelector("tbody").innerHTML = ''
    for (let i = 0; i < products.length; i++) {//forEach is nicer
        totalPrice += parseInt(products[i].price)
        DrawProduct(products[i])
    }
    document.getElementById("totalAmount").textContent = totalPrice + '$';
    sessionStorage.setItem("totalPrice", totalPrice)
}
const DrawProduct = (product) => {
    let tmp = document.getElementById("temp-row");
    let ProductChild = tmp.content.cloneNode(true)
    let url = `./pictures/${product.image}.jpg`

 ProductChild.querySelector(".image").style.backgroundImage = `url(${url})`
   /* cloneProduct.querySelector(".img").src = "./pictures/" + product.image*/
   /* productChild.querySelector(".img").src = "./pictures/" + product.image + '.jpg'*/
    ProductChild.querySelector(".itemName").textContent = product.name
    ProductChild.querySelector(".itemNumber").innerText = product.price
    //cloneProduct.querySelector(".description").innerText = product.descreaptionProduct
    ProductChild.querySelector(".expandoHeight").addEventListener('click', () => { deleteFromCart(product) })
    document.querySelector("tbody").appendChild(ProductChild)
}
const deleteFromCart = (product) => {
    let products = sessionStorage.getItem("shopingBag")
    products = JSON.parse(products)
    let i = 0;//use indexof instead of for
    for (; i < products.length; i++) {
        if (products[i].id == product.id)
            break;
    }
    products.splice(i, 1);
    sessionStorage.setItem("shopingBag", JSON.stringify(products))
    DrawProducts()
}
const placeOrder = async() => {
    shopingBag = JSON.parse(sessionStorage.getItem("shopingBag")) || []
    console.log(shopingBag)
    let user = JSON.parse(sessionStorage.getItem("user"))
    if (user != -1 && shopingBag.length != 0) {
        let products = []
        for (let i = 0; i < shopingBag.length; i++) {//forEach is nicer
            let currentProduct = { productId: shopingBag[i].id, quentity: 1 }
            products.push(currentProduct);
            console.log(currentProduct)
        }
        try {
            const responsePost = await fetch("https://localhost:7057/api/Order/", {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({
                    userId: user,
                    orderDate: "2025-01-05",
                    orderSum: JSON.parse( sessionStorage.getItem("totalPrice")),
                    orderItems: products
                })


            });
            if (!responsePost.ok) {
                throw new Error(`HTTP error! status:${response.status}`)
            }

            const dataPost = await responsePost.json();

            alert(`${dataPost.id} הזמנה בוצעה בהצלחה `)
            sessionStorage.setItem("shopingBag", JSON.stringify([]))
            sessionStorage.setItem("category", JSON.stringify([]))
            window.location.href = 'Products.html'


        }
        catch (error) {
            console.log(error)
        }
        }
}