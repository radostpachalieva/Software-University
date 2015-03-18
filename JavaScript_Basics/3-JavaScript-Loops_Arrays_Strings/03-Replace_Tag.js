function solve(inputString) {
    var match;
    var regex = /<a(.*?)>(.*?)<\/a>/g;
    while (match = regex.exec(inputString)) {
        var initial = match[0];
        var replacementString = '[URL' + match[1] + ']' + match[2] +  '[/URL]';
        inputString = inputString.replace(initial, replacementString);
    }
    console.log(inputString);
}

solve('<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>' + '<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>');