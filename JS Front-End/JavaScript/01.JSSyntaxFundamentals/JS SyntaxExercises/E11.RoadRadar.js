function radar(speed, zone) {
  let speedLimit = 0;
  switch (zone) {
    case "motorway":
      speedLimit = 130;
      break;
    case "interstate":
      speedLimit = 90;
      break;
    case "city":
      speedLimit = 50;
      break;
    case "residential":
      speedLimit = 20;
      break;
  }

  if (speed > speedLimit) {
    let speedStatus = "";
    const speedDiff = speed - speedLimit;

    if (speedDiff > 0 && speedDiff <= 20) {
      speedStatus = "speeding";
    } else if (speedDiff > 20 && speedDiff <= 40) {
      speedStatus = "excessive speeding";
    } else {
      speedStatus = "reckless driving";
    }

    console.log(
      `The speed is ${speedDiff} km/h faster than the allowed speed of ${speedLimit} - ${speedStatus}`
    );
  } else {
    console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
  }
}

radar(-120, "motorway");