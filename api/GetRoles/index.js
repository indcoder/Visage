module.exports = async function (context, req) {
    const user = req.body || {};

    context.log('JavaScript HTTP trigger function processed a request.');

    const roles = user["https://dev-visage.in/roles"] || [];


    
    context.res.json({
        roles
    });
}