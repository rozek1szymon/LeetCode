var emails =["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"];

var cleanEmails = new Map();
    for (var i = 0; i < emails.length ; i ++)
    {
        var [local, domain] = emails[i].split('@'); // at this step cariable local is going to have a text to "@" symbol and domain variable is going to have a text after "@" appearance
        local = local.split("+")[0].replace(/\./g,''); //this functions split string ang give you everything before + and replace function replace globally every dot by non space.
        cleanEmails.set(local+ "@" + domain); // when we want to add to this sth which is the same as sth what was in the map it wont do this ex. we have text "lol" in the map so when we want to add "lol" we cant do this beacouse it s already exist 
    }
     console.log(cleanEmails.size);

