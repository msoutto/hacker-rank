function hourglassSingle(arr, i, j) {
  let result = arr[i][j] + arr[i][j+1] + arr[i][j+2];
  result += arr[i+1][j+1];
  result += (arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]);
  
  return result;
}

function hourglassSum(arr) {
  let result = Number.NEGATIVE_INFINITY;
  
  for (let i = 0; i < arr.length - 2; i++) {
      for (let j = 0; j < arr.length - 2; j++) {
          let sum = hourglassSingle(arr, i, j);
          if (sum > result)
            result = sum;
      }
  }
  
  return result;
}

const arr = [[1, 1, 1, 0, 0, 0],
            [0, 1, 0, 0, 0, 0],
            [1, 1, 1, 0, 0, 0],
            [0, 0, 2, 4, 4, 0],
            [0, 0, 0, 2, 0, 0],
            [0, 0, 1, 2, 4, 0]];


console.log(hourglassSum(arr));