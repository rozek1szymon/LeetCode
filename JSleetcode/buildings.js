var grid = [[3,0,8,4],[2,4,5,7],[9,2,6,3],[0,3,1,0]];
var biggestFromTandB= [];
var biggestFromLandF= [];
var sum2=0;
var sum1=0;
for(var i=0; i<grid.length;i++)
    {
        biggestFromLandF[i]=0;
        biggestFromTandB[i]=0;
       // 
       for(var j=0; j<grid[i].length; j++)
           {
               
                if(grid[j][i]>biggestFromTandB[i])
                    {
                       biggestFromTandB[i]=grid[j][i];
                    }
               if(grid[i][j]>biggestFromLandF[i])
                   {
                      
                       biggestFromLandF[i] =grid[i][j];
                   }
            
           sum1+=grid[i][j];
           }
       
    }
for(var i=0; i<grid.length; i++)
{
     for(var j=0; j<grid[i].length; j++)
{   
   if(grid[i][j]<biggestFromLandF[i] && grid[i][j]<biggestFromTandB[j]) 
       {
           if(biggestFromLandF[i]<biggestFromTandB[j])
               {
                 grid[i][j]= biggestFromLandF[i];
               }
           else
               grid[i][j]= biggestFromTandB[j];
               
          
       }
    sum2+=grid[i][j];
}
   
}
console.log("1")
//return sum2-sum1;

