


const getUser = () => {
    const email = document.querySelector("#email").value

    const password = document.querySelector("#password").value

    const firstName = document.querySelector("#firstName").value

    const lastName = document.querySelector("#lastName").value

    const user = { email, password, firstName, lastName }

    return user
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
        alert("הפרטים עודכנו בהצלחה")
    }
    catch (err) {
        alert(err)
        alert("לא הצלחנו לעדכן את הפרטים")
    }


}
