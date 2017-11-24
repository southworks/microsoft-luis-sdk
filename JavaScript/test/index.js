var LuisClient = require('../');

var client = new LuisClient();
var appId = 'f8ef55e6-1543-4a36-95da-497c21feea65';
var key = '42176485494149818968315538ddf05b';
var q = 'we have one simple intent and green and father and child';
// var q = 'we have one simple intent';
// var q = 'today test from today to tomorrow test one million tests eleventh tests three ars'
var result = client.prediction.getPredictionsFromEndpointViaGet('westus', key, q, appId);

result.then(r => {
    console.log(JSON.stringify(r, null, '\t'));
});
