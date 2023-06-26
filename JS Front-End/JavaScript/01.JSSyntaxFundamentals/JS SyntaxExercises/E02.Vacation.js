function vacation(groupSize, group, dayOfWeek) {
  let price = 0;

  switch (dayOfWeek) {
    case "Friday":
      switch (group) {
        case "Students":
          price = 8.45;
          break;
        case "Business":
          price = 10.9;
          break;
        case "Regular":
          price = 15;
          break;
      }
      break;
    case "Saturday":
      switch (group) {
        case "Students":
          price = 9.8;
          break;
        case "Business":
          price = 15.6;
          break;
        case "Regular":
          price = 20;
          break;
      }
      break;
    case "Sunday":
      switch (group) {
        case "Students":
          price = 10.46;
          break;
        case "Business":
          price = 16;
          break;
        case "Regular":
          price = 22.5;
          break;
      }
      break;
  }

  let totalPrice = groupSize * price;

  if (group == "Students" && groupSize >= 30) {
    totalPrice *= 0.85;
  } else if (group == "Business" && groupSize >= 100) {
    totalPrice = (groupSize - 10) * price;
  } else if (group == "Regular" && groupSize >= 10 && groupSize <= 20) {
    totalPrice *= 0.95;
  }
  console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

vacation(40, "Regular", "Saturday");
