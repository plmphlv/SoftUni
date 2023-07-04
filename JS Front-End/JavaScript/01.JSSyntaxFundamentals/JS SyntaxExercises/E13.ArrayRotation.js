function rotate(myArr, rotations){

    for (let i = 0; i < rotations; i++)
    {
        const firstElement=myArr.shift();
        myArr.push(firstElement);
    }
console.log(myArr);
}
rotate([51, 47, 32, 61, 21], 2);