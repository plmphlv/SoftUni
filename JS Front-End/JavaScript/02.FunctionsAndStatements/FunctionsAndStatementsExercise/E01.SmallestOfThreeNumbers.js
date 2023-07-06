function smallestNumFinder(num1,num2, num3) {
    let nums=[num1,num2,num3];
    let smallestNum=Number.MAX_SAFE_INTEGER;

for (const iterator of nums) {
    if(iterator<smallestNum){
        smallestNum=iterator;
    }
}
console.log(smallestNum);
}

smallestNumFinder(2, 5, 3);