function addAndSubtract(num1, num2, num3) {
    function sum(){
        return num1 + num2;
    }

    function subtract(x,y) {
        return x-y;
    }

    const sumresult = sum();
    const subtractResult = subtract(sumresult, num3);

    return subtractResult;
}

console.log(addAndSubtract(23,6,10));