function rotLeft(a, d) {
  let itemsRotated = a.splice(0, d);
  return a.concat(itemsRotated);
}

let arr = [1, 2, 3, 4, 5];
let d = 4;

console.log(rotLeft(arr, d));