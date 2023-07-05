function SortNumbers(array) {
    const sortedArray = array.sort((a, b) => a - b);
    const resultsArray = [];
    const lenghtArr = array.length;

    for (let index = 0; index < lenghtArr; index++) {
      if (index % 2 === 0) {
        resultsArray.push(sortedArray.shift());
      } else {
        resultsArray.push(sortedArray.pop());
      }
    }
    return resultsArray;
}

SortNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);