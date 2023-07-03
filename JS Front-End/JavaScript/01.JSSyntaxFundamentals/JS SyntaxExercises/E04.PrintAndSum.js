function printAndSum(start, end) {
  let sum = 0;
  let nums = [];
  for (let index = start; index <= end; index++) {
    sum += index;
    nums.push(index);
  }
  console.log(nums.join(" "));
  console.log(`Sum: ${sum}`);
}
printAndSum(0, 26);
