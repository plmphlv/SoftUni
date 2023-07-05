function repeat(word, repeats) {
  let result = "";

  for (let index = 1; index <= repeats; index++) {
    result += word;
  }

  return result;
}
repeat("abc",3)