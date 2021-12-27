module.exports = async function (context, req) {
    context.log('JavaScript HTTP trigger function processed a request.');

    const roles = ['weathercaster', 'dummy'];
    
    console.log({roles});

    context.res.json({
        roles
    });
}