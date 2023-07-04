function revealPords(words, sentance) {
    const wordsArr = words.split(", ");
    const sentanceArr = sentance.split(" ");

    for (const iterator of wordsArr) {
        for (let index = 0; index < sentanceArr.length; index++) {
          if(iterator.length == sentanceArr[index].length){
            sentanceArr[index] = iterator;
            break;
          }
        }
    }

    console.log(sentanceArr.join(" "));
}
revealPords(
  "great",
  "softuni is ***** place for learning new programming languages"
);