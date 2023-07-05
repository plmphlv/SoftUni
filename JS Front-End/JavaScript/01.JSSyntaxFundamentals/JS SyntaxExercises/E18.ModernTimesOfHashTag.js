function solve(text){
    const pattern = /(#\w+)/g;
const matches= text.split(" ");

for (const iterator of matches) {
    if(iterator.match(pattern)){
        console.log(iterator.replace('#',''));
    }
}
}

solve(
  "The symbol # is known #variously in English-speaking #regions as the #number sign"
);