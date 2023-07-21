function convertToJson(firsName,name2, colour) {
    const person = {
      name: firsName,
      lastName: name2,
      hairColor: colour,
    };

    console.log(JSON.stringify(person));
}

convertToJson("George", "Jones", "Brown");