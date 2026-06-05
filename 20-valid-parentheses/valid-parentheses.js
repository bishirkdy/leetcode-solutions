/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function (s) {
    const track = {
        ')': '(',
        '}': '{',
        ']': '['
    };
    const stack = [];

    for (let c of s) {
        if(Object.values(track).includes(c)){
            stack.push(c)
        }else if(stack.length === 0 || stack.pop() !== track[c]){
            return false
        }
    }
    return stack.length === 0
};