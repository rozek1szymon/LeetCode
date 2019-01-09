var J="ba";
var S="aAAAabbbb";
var inputS=S;
var letters = [];
var numberOfAppears=0;
var actualPosition;
var slicedString =[];
var numberOfLetters=0;
for(var i=0; i<J.length; i++)
    {
      letters[i]=J.charAt(i); 
        
        console.log(letters[i]);
   
   
        
        if(S.search(letters[i])!= -1)
            {
             //while(S.search(letters[i])!= -1)
            // {
               while(S.search(letters[i])!= -1)
               {
                var j=0;
                numberOfAppears++;
                actualPosition = S.search(letters[i]);
                slicedString[j]=S.slice(actualPosition+1,S.length);
                S=slicedString[j];
                   console.log(slicedString[j]);
                j;
               }
               }
              S=inputS;
                } 

       
       
    
console.log(numberOfAppears);
