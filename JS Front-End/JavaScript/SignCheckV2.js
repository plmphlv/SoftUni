function signCheck(nums) {
  let negattive = 0;

  for (const iterator of nums) {
    if (iterator < 0) {
      negattive++;
    }
  }

  if (negattive % 2 === 0) {
    console.log("Positive");
  } else {
    console.log("Negative");
  }
}

signCheck([5, 12, 15, -1, -5, -5]);
