function solve(number) {
    const numbString = number.toString();
    let odd = 0;
    let even = 0;

    for (let index = 0; index < numbString.length; index++) {
        const digit = parseInt(numbString[index]);
      if (digit % 2 === 0) {
        even += digit;
      } else {
        odd += digit;
      }
    }

    console.log(`Odd sum = ${odd}, Even sum = ${even}`);
}

solve(3495892137259234);