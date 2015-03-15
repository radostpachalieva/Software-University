"use strict";

function getKilometersPerSeconds(value) {
    var knots = value * 0.539957;
    console.log(knots.toFixed(2));
}

getKilometersPerSeconds(20);        // 10.80
getKilometersPerSeconds(112);       // 60.48
getKilometersPerSeconds(400);       // 215.98