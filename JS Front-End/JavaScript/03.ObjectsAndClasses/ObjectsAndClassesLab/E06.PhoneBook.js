function collectPhone(params) {
    const phoneObj = params.reduce((acc, curr)=>{
        const[name,phone] = curr.split(' ');
        acc[name] = phone;

        return acc;
    },{});

    Object.entries(phoneObj).forEach(([key, value])=>{
        console.log(`${key} -> ${value}`);
    });
}

collectPhone([
  "George 0552554",
  "Peter 087587",
  "George 0453112",
  "Bill 0845344",
]);