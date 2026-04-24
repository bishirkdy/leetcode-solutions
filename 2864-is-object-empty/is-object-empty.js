/**
 * @param {Object|Array} obj
 * @return {boolean}
 */
var isEmpty = function(obj) {
    const key = Object.keys(obj)
    return key.length ? false : true
};