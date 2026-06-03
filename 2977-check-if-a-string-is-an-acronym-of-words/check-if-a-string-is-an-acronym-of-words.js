/**
 * @param {string[]} words
 * @param {string} s
 * @return {boolean}
 */
var isAcronym = function(words, s) {
    let res = []
    for(let i of words){
        res.push(i[0])
    }
    return res.join("") === s
};