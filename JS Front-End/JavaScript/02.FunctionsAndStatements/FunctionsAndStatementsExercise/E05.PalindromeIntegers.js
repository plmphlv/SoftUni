function palindromeIntegers(nums) {
  for (const iterator of nums) {
    const selected = parseInt(iterator.toString().split("").reverse().join(""));
    if (iterator === selected) {
      console.log(true);
    } else {
      console.log(false);
    }
  }
}
palindromeIntegers([32, 2, 232, 1010]);
