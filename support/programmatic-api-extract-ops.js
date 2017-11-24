var _ = require('lodash');
var stringify = require('csv-stringify');
var api = require('../data-plane/LUIS/v2.0/LUIS-Programmatic-API.swagger.json');


var opsByPath = _.mapValues(api.paths, (o, k) => extractOps(k, o));
var ops = _.flatten(_.values(opsByPath));


// console.log(JSON.stringify(ops, null, '\t'))
// console.log(Array.from(new Set(ops.map(o => o.operation.split('_')[0]))));

var columns = ['PATH', 'METHOD', 'OPERATION'];
var data = [ columns, ...ops.map(o => [o.path, o.method.toUpperCase(), o.operation])];
var strinfier = stringify(data);
strinfier.pipe(process.stdout);


function extractOps(path, pathConfig) {
    return ['get', 'post', 'put', 'delete', 'patch'].map(method => {
        return pathConfig[method] ? getDesc(path, pathConfig, method) : null
    }).filter(op => op !== null);
}

function getDesc(path, pathO, method) {
    return {
        path: path,
        method: method,
        operation: pathO[method].operationId
    };
}