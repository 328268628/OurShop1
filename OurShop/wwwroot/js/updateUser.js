﻿


const getUser = () => {
    const email = document.querySelector("#email").value

    const password = document.querySelector("#password").value

    const firstName = document.querySelector("#firstName").value

    const lastName = document.querySelector("#lastName").value

    const user = { email, password, firstName, lastName }

    return user
}


const getPassword = () => {
    const password = document.querySelector("#password").value
    return password;
}
const updateLevel = (dataPost) => {
    const level = document.querySelector("#level")
    console.log(level.value)
    level.value = dataPost
    console.log(level.value)

}


const cheakPassword = async () => {
    const password = getPassword()
    try {
        const responsePost = await fetch('https://localhost:7057/api/Users/password', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },

            body: JSON.stringify(password)

        })

        const dataPost = await responsePost.json()
        if (dataPost < 3) {
            alert("חוזק סיסמא לא תקין")
        }
       /* alert(dataPost)*/
        else
            updateLevel(dataPost)
    }
    catch {
        alert(err)

    }
}




const updateUserr = async () => {
    const user = getUser()
    const userId = sessionStorage.getItem("Id")
    try {
        const responsePost = await fetch(`https://localhost:7057/api/Users/${userId}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)

        })
        //status==204
        //not found
        if (responsePost.ok)
            alert("update user sucsessfully")
        else {
            if (responsePost.status === 400) {
                alert("חוזק סיסמא אינו תקין")
            }
        }
        /*alert(dataPost)*/
    }
    
    catch (err) {
        alert(err)
        alert("לא הצלחנו לעדכן את הפרטים")
    }


}
