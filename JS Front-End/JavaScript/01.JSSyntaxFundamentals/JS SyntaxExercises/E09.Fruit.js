function fruitsCalc(fruit, grams, pricePerKilo) {
  const kilos = (grams / 1000).toFixed(2);
  const price = (kilos * pricePerKilo).toFixed(2);
  console.log(`I need $${price} to buy ${kilos} kilograms ${fruit}.`);
}
fruitsCalc("apple", 1563, 2.35);