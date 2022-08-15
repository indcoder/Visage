
module.exports = async function (context, req) {
    const user = req.body || {};
    console.log("The user is ");
    console.log({user});
    console.log("End of user");
    context.log({user});
    console.log('JavaScript HTTP trigger function processed a request.');
    const claims = user.claims || [];
    const roles = [];


    
    for(i=0; i < claims.length; i++) {
        if(claims[i].typ === "https://dev-visage.in/roles") {
            roles.push(claims[i].val);
        }
    }

    /* Iterate through the claims array and push the value to roles*/


  
    context.res.json({
        roles
    });
}