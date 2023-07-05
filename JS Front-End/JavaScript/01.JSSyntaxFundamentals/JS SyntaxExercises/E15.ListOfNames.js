function sortNames(names) {
    const sortedNames = names.sort();
    for (let index = 0; index < sortedNames.length; index++) {
      console.log(`${index + 1}.${sortedNames[index]}`);
    }
}
sortNames(["John", "Bob", "Christina", "Ema"]);