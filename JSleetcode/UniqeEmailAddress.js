var emails = ["tyy.p.kap@leetcode.com"];
var domainnames = [];
var indexof;
var dots=[];
var pluses;
var tableOfStrings =[];
var j=0;
var after;
//console.log(emails.length-1);
for(var i=0; i<emails.length; i++)
    {
    
       indexof=emails[i].indexOf("@");
   
         while(emails[i].indexOf(".")!=-1)
             {
                
                 if(emails[i].indexOf(".")!=-1)
                     {
                         dots.push(emails[i].indexOf("."));
                 
                          console.log(dots[dots.length-1]);
                
                       
                           
                     tableOfStrings.push(emails[i].slice(0,dots[dots.length-1]));     
                     emails[i]=(emails[i].slice(dots[dots.length-1]+1,indexof));
                         
                     }
                 if(emails[i].indexOf(".")==-1) 
                      {
                         tableOfStrings.push(emails[i].slice(0,indexof));   
                      }
                 }
        
     }
var now="";
for(var k=0; k<tableOfStrings.length; k++)
    {
      
      now+= tableOfStrings[k];
    }
        

console.log(now);