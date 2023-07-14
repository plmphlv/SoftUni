function loadingBar(progres) {
  const progresBar = [];
  for (let index = 0; index < 10; index++) {
    if (index < progres / 10) {
      progresBar.push("%");
    } else {
      progresBar.push(".");
    }
  }

  if (progres === 100) {
    console.log(`${progres}% Complete!`);
    console.log(`[${progresBar.join("")}]`);
  } else {
    console.log(`${progres}% [${progresBar.join("")}]`);
    console.log(`Still loading...`);
  }
}

loadingBar(50)