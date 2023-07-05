function fruitsCalc(fruit, grams, pricePerKilo) {
  const kilos = (grams / 1000);
  const price = (kilos * pricePerKilo);
  console.log(
    `I need $${price.toFixed(2)} to buy ${kilos.toFixed(2)} kilograms ${fruit}.`
  );
}
fruitsCalc("apple", 1563, 2.35);