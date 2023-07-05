const calculator = {
  multiply: (x, y) => x * y,
  add: (x, y) => x + y,
  subtract: (x, y) => x - y,
  divide: (x, y) => x / y,
};
const doMaths = (num1,num2, operator)=> calculator[operator]?calculator[operator](num1,num2):0;

const result = doMaths(5, 4, "555");

console.log(result);