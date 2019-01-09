var table =["s*$z.$y*$sm*so+n@kupa"];

var[local,surname] = table[0].split("@");
//console.log(local);
//console.log(surname);

local = local.split("+")[0]; // this operation is giving you a string to "+" symbol becouse in fact after split you have 2 strings, by write down 1 in the brackets you can see everything after "+"
local=local.replace(/\./g,''); //this function delete every s in the text /g mean that global in every function; remember that when u have special functions u have to use
 // /\&/g
console.log(local);
