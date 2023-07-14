function convertToObject(jsonStr) {
  const person = JSON.parse(jsonStr);

Object.keys(person).forEach((key) => {
  console.log(`${key}: ${person[key]}`);
});
}

convertToObject('{"name": "George", "age": 40, "town": "Sofia"}');
