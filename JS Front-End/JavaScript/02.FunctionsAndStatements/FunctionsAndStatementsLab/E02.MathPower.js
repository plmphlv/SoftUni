function power(num, pow){
    let result = 1;

    for (let index = 1; index <= pow; index++) {
        result*=num
    }
    console.log(result)
}
power(3,8);