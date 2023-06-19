function ReverseNums(n, numArray) {
  let revNums = [];
  for (let i = n - 1; i >= 0; i--) {
    revNums.push(numArray[i]);
  }

  let arrString = "";
  for (let first of revNums) {
    arrString += `${first} `;
  }

  console.log(arrString);
}

ReverseNums(4, [-1, 20, 99, 5]);
