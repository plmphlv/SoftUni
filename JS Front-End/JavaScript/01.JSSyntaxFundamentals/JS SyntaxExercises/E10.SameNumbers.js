function sameNumbers(digits) {
  const digitString = digits.toString();
  let sum = 0;
  let same = true;
  
  for (let index = 0; index < digitString.length; index++) {
    const element1 = parseInt(digitString[index]) ;
    if (index < digitString.length - 1) {
      const element2 = parseInt(digitString[index + 1]);
      if (element1 != element2) {
        same = false;
      }
    }
    sum += element1;
  }

  console.log(same)
  console.log(sum);
}
sameNumbers(1234);