//Input
//    [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]
//Output
//    [18.4, 53.6, 96, 136, 160, 169.6, 280, 320.8, 336]

function solve(arr){
    arr = arr.filter(function (x) {
        return x >= 0 && x <= 400;
    });
    console.log(arr);

    arr = arr.map(function(x) {
        return parseFloat(( 0.8 * x).toFixed(1));
    });
    console.log(arr);

    arr = arr.sort(function (a, b) {
        return a > b;
    });
    console.log(arr);
}

solve([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);