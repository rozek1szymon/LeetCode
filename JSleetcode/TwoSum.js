var nums=[3,3];
var target=6;
   const hash = {};
    for(var i=0; i<nums.length; i++) {
        if (nums[i] in hash) 
            {
                console.log(hash[nums[i]]);
                console.log(i);
                break;
                
            }
             hash[target-nums[i]] = i;
    }

  //console.log(-1);
//console.log(-1);