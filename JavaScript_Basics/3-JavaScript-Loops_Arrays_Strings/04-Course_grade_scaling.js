function solve(arr) {

    for ( var i = 0; i < arr.length; i++) {
        arr[i].score *= 1.1;
        arr[i].score = Math.round(arr[i].score * 10) /10;
        if(arr[i].score >= 100){
            arr[i]['hasPassed'] = true;
        }

        else{
            arr[i]['hasPassed'] = false;
        }

        arr = arr.sort(function(a,b){
            return a.name > b.name;
        });
    }
    console.log(JSON.stringify(arr));
}

//[{"name":"Алекс","score":377.3,"hasPassed":true},{"name":"Габриела","score":440,"hasPassed":true},{"name":"Лилия","score":319,"hasPassed":true},{"name":"Пешо","score":100.1,"hasPassed":true}]

solve([
        {
            'name' : 'Пешо',
            'score' : 91
        },
        {
            'name' : 'Лилия',
            'score' : 290
        },
        {
            'name' : 'Алекс',
            'score' : 343
        },
        {
            'name' : 'Габриела',
            'score' : 400
        },
        {
            'name' : 'Жичка',
            'score' : 70
        }
    ]
);