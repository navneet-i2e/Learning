//object is kind of like map
//where we have key:value pairs
let obj = { name: "Navneet", age: 22, clg: "TECHNO", married: false };
console.log(obj);

//to access object properties
console.log(obj.name, obj.age, obj.clg, obj.married);

let car = {
  name: "Fortuner",
  "nick name": "Ghoda", //key can contain spaces
  milege: 10,
  price: 2000000,
  "is Bought": false,
  isDiesel: true,
};
console.log(car.name);

console.log(car["is Bought"]);
console.log(car["price"]);
car.price = 3000000;
console.log(car.price);
car["price"] = 3000000;

console.log(car["price"]);

var details = {
  name: "Navneet",
  age: 22,
  college: "TECHNO",
  isMarried: false,
};
console.log(details.age);
console.log(details["age"]);
console.log(details.college);
console.log(details["college"]);


for (const key in details) {
  console.log(key, details[key]);
}