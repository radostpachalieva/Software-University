//Input
//["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]]
//
//Output
//Min number: 0
//Max number: 12
//Most frequent number: 2
//    [12, 9, 2, 2, 0]

function solve(arr) {
    arr = arr.filter(function (x) {
        return (!isNaN(x));
    });

    arr = arr.sort(function (a, b) {
        return a > b;
    });
    console.log("Min number: " + arr[0]);
    console.log("Min number: " + arr[arr.length - 1]);

    //Counts the occurrences of a given element in array
    Array.prototype.occurs = function (arg) {
        var counter = 0;
        for (var i = 0; i< this.length; i++){
            if(this[i] === arg)
                counter++;
        }
        return counter;
    }

    var maxFreq = 0;
    var mostFrequentNum = 0;
    for (var i = 0; i < arr.length; i++) {
        var currElement = arr[i];
        var frequency = arr.occurs(currElement);
        if (frequency > maxFreq){
            maxFreq = frequency;
            mostFrequentNum = currElement;
        }
    }

    console.log("Most frequent number: " + mostFrequentNum );
    console.log(arr.reverse());

 }

solve(["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]]);