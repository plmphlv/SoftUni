function collectPhone(params) {
  const meeting = params.reduce((acc, curr) => {
    const [weekday, name] = curr.split(" ");

    if (acc.hasOwnProperty(weekday)) {
      console.log(`Conflict on ${weekday}!`);
    } else {
      acc[weekday] = name;
      console.log(`Scheduled for ${weekday}`);
    }
    return acc;
  }, {});

  Object.entries(meeting).forEach(([key, value]) => {
    console.log(`${key} -> ${value}`);
  });
}

collectPhone([
  "Friday Bob",
  "Saturday Ted",
  "Monday Bill",
  "Monday John",
  "Wednesday George",
]);