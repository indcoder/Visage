module.exports = async function (context, req) {
    const user = req.body || {};
    
    console.log("The user is ");
    console.log({user});
    console.log("End of user");
    
    context.log('JavaScript HTTP trigger function processed a request.');

    const roles = user["https://dev-visage.in/roles"] || [];


    
    context.res.json({
        roles
    });
}
