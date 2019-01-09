var J="ba";
var S="aAAAabbbb";


if (!J || !S) console.log(0);
    
    let count = 0;
    for (const c of S) // go through everyone element in S strimg
    {
       // console.log(c);
        if (J.includes(c)) count++;  // if J string have same letter as S string in a moment number of same letters are increase
    }
    
    console.log(count);