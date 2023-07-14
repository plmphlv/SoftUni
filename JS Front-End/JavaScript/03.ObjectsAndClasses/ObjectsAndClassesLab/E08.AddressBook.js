function collectPhone(input) {
 let addressbook = {};
 for (let line of input) {
   let [name, address] = line.split(":");
   addressbook[name] = address;
 }
 let sorted = Object.entries(addressbook);
 sorted.sort((a, b) => a[0].localeCompare(b[0]));

  Object.entries(addressbook).forEach(([key, value]) => {
    console.log(`${key} -> ${value}`);
  });
}

collectPhone(['Bob:Huxley Rd',
'John:Milwaukee Crossing',
'Peter:Fordem Ave',
'Bob:Redwing Ave',
'George:Mesta Crossing',
'Ted:Gateway Way',
'Bill:Gateway Way',
'John:Grover Rd',
'Peter:Huxley Rd',
'Jeff:Gateway Way',
'Jeff:Huxley Rd']
);