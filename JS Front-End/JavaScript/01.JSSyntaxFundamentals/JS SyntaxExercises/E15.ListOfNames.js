function sortNames(names) {
    names = names.sort();
    for (let index = 0; index < names.length; index++) {
      console.log(`${index+1}.${names[index]}`);
    }
}
sortNames(["John", "Bob", "Christina", "Ema"]);