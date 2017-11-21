var LuisClient = require('../');

var client = new LuisClient();
var result = client.prediction.getPredictionsFromEndpointViaGet('westus', '137c6310792b4b1199b04ce50df640c1', 'End of day 2017/11/21', '0dcfade4-3c07-4afb-a775-f0e8a4bcd395');

result.then((r) => console.log(JSON.stringify(r, null, '\t')));
