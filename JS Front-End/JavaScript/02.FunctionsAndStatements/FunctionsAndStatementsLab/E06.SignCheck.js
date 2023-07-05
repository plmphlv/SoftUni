function  signCheck(num1,num2,num3) {
    const numArr=[num1,num2,num3];
    let negattive=0;

    for (const iterator of numArr) {
        if(iterator < 0){
            negattive++;
        }
    }

    if(negattive===0 || negattive===2){
        console.log("Positive");
    }
    else{
        console.log("Negative");
    }
}

signCheck(-5, -12, 15);