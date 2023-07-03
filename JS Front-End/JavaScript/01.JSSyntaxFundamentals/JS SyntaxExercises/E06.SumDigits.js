function sumDigits(digits) {
  const digitString = digits.toString();
  let sum = 0;
  for (let index = 0; index < digitString.length; index++) {
    const element = digitString[index];
    sum += parseInt(element);
  }
  console.log(sum);
}
sumDigits(245678);
