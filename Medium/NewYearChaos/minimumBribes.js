function minimumBribes(q) {
  let total = 0;

  for (let i = 0; i < q.length; ++i) {
    q[i]--; // Easier to understand when q[0] = 0, q[1] = 1...

    if (q[i] - i > 2) {
      return "Too chaotic";
    }

    for (let j = (q[i] - 1); j < i; j++) { // Who bribed i cannot be more than 1 position ahead of original i position
      if (q[j] > q[i]) {
        total++;
      }
    }
  }

  return total;
}

let q = [1, 2, 5, 3, 7, 8, 6, 4];
// 0 1 4 2 6 7 5 3
/*
1 2 5 3 7 6 8 4
1 2 5 3 7 6 4 8
1 2 5 3 6 7 4 8
1 2 5 3 6 4 7 8
1 2 5 3 4 6 7 8
1 2 3 5 4 6 7 8
1 2 3 4 5 6 7 8
*/
console.log(minimumBribes(q));

/*
// FIRST IMPLEMENTATION
function minimumBribes(q) {
  let total = 0;
  let counters = Array(q.length).fill(0);

  for (let element = q.length; element > 0; element--) {
    let i = q.indexOf(element);

    while (element > i + 1) { // element 1 in index 0...
      if (counters[element - 1] == 2) {
        break;
      }
      
      q[i] = q[i + 1];
      q[i + 1] = element;

      counters[element - 1]++;
      i++;
    }
  }

  for (let i = 0; i < q.length; i++) {
    if (q[i] != i + 1) {
      return "Too chaotic";
    }
    console.log("counter(" + (i+1).toString() + "): " + counters[i].toString());
    total += counters[i];
  }

  return total;
}
*/