var num = 1;
var done="";

var complement = num.toString(2);


console.log(complement);
for(var i=0; i<complement.length; i++)
{
if(complement[i]=="0")
 {
      done += complement[i].replace("0","1");
 }

else
{
    done += complement[i].replace("1","0");     
}
 
}

var final=  parseInt(done,2);//parse string binary to int 

console.log(final);
            

