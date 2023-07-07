function validatePassword(password){
    let isValid = true;
    let pass = password.lenght;
    
    if (!(password.length >= 6 && password.length <= 10)) {
      console.log("Password must be between 6 and 10 characters");
      isValid = false;
    }
    
    const pattern = /([^a-zA-Z0-9]+)/g;
    
    if(password.match(pattern)){
        console.log("Password must consist only of letters and digits");
        isValid = false;
    }

    const pattern2 = /([A-Za-z]+[0-9]{2,})/g;
    
    if (!(password.match(pattern2))){
        console.log("Password must have at least 2 digits");
        isValid = false;
    }

    if(isValid){
        console.log("Password is valid");
    }
}

validatePassword("logIn");