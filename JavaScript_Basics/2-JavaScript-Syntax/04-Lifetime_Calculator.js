function calcSupply(age, maxAge, food, foodPerDay) {
    console.log((maxAge - age) * 365 * foodPerDay + "kg of " +
    food + " would be enough until I am " + maxAge + " years old.");
}

calcSupply(38, 118, "chocolate", 0.5);      // 14600kg of chocolate would be enough until I am 118 years old.
calcSupply(20, 87, "fruits", 2);            // 48910kg of fruits would be enough until I am 87 years old.
calcSupply(16, 102, "nuts", 1.1);           //  34529kg of nuts would be enough until I am 102 years old.