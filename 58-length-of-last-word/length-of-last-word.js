/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    let word = s.trimEnd()
     word = word.split(" ")
    return word[word.length - 1].length
};