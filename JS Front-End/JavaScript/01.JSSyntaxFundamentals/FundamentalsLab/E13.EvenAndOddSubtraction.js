function OddEvenSum(numArr) {
  let oddSum = 0;
  let evenSum = 0;
  for (let element of numArr) {
    let x = Number(element);
    if (x % 2 == 0) {
      evenSum += x;
    } else {
      oddSum += x;
    }
  }
  console.log(evenSum - oddSum);
}

OddEvenSum([3, 5, 7, 9]);
