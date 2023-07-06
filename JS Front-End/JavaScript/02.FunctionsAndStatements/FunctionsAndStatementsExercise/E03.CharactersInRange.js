function range(char1, char2) {
  let charCodeStart = 0;
  let charCodeEnd = 0;
  let charArr = [];

  if (char1.charCodeAt(0) > char2.charCodeAt(0)) {
    charCodeStart = char2.charCodeAt(0);
    charCodeEnd = char1.charCodeAt(0);
  } else {
    charCodeStart = char1.charCodeAt(0);
    charCodeEnd = char2.charCodeAt(0);
  }

  for (let i = charCodeStart + 1; i < charCodeEnd; i++) {
    charArr.push(String.fromCharCode(i));
  }

  console.log(charArr.join(" "));
}

range("#", ":");
