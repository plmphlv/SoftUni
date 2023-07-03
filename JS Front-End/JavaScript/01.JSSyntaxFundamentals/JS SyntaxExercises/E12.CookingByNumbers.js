function cookNumbers(
  num,
  operation1,
  operation2,
  operation3,
  operation4,
  operation5
) {
    let number = parseInt(num);
    const opsArr = [operation1, operation2, operation3, operation4, operation5];

    for (const iterator of opsArr) {
        switch (iterator) {
          case "chop":
            number/=2;
            break;
          case "dice":
            number= Math.sqrt(number);
            break;
          case "spice":
            number+=1;
            break;
          case "bake":
            number*=3;
            break;
          case "fillet":
            number-=(number*0.2);
            break;
        }
        console.log(number);
    }
}
cookNumbers("9", "dice", "spice", "chop", "bake", "fillet");