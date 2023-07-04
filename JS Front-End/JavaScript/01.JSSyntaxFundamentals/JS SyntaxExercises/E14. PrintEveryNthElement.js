function print(myArr, iteration){
    let arr2 = [];
    for (let index = 0; index < myArr.length; index += iteration) {
      arr2.push(myArr[index]);
    }
    console.log(arr2);
}

print(["1", "2", "3", "4", "5"], 6);