function catMaker(arr) {
  class Cat {
    constructor(name, age) {
      this.catName = name;
      this.catAge = age;
    }

    meow() {
      console.log(`${this.catName}, age ${this.catAge} says Meow`);
    }
  }

  const cats = [];
  for (const iterator of arr) {
    const cat = iterator.split();
    cats.push(new Cat(cat[0], cat[1]));
  }

  cats.forEach(cat => {
    cat.meow();
  });
}

catMaker(["Candy 1", "Poppy 3", "Nyx 2"]);