function citiesLoop(city) {
    Object.keys(city).forEach((key)=>{
        console.log(`${key} -> ${city[key]}`);
    });
}

citiesLoop({
  name: "Plovdiv",
  area: 389,
  population: 1162358,
  country: "Bulgaria",
  postCode: "4000",
});